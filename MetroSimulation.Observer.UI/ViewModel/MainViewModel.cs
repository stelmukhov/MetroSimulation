using System;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using MetroSimulation.Observer.UI.Model;
using GalaSoft.MvvmLight.CommandWpf;
using MetroSimulation.Observer.UI.SRT;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MetroSimulation.Observer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase, SRT.ITrainObserverServiceCallback
    {

        public Dictionary<TrainUI, SRT.TrainObserverServiceClient> TrainsDictionary { get; set; }
        public ObservableCollection<TrainUI> Trains { get; set; }
        private SRT.TrainObserverServiceClient tempProxy;

        #region prperties
        TrainObserverServiceClient CurrentCallback => OperationContext.Current.
            GetCallbackChannel<TrainObserverServiceClient>();
        private string _ipAdress = "localhost";
        public string IpAdress
        {
            get { return _ipAdress; }

            set
            {
                if (_ipAdress == value)
                {
                    return;
                }

                _ipAdress = value;
                RaisePropertyChanged(nameof(IpAdress));
            }
        }

        private string _portAdress = "7997";
        public string PortAdress
        {
            get { return _portAdress; }

            set
            {
                if (_portAdress == value)
                {
                    return;
                }

                _portAdress = value;
                RaisePropertyChanged(nameof(PortAdress));
            }
        }

        private bool _flyOutIsOpen = true;
        public bool FlyOutIsOpen
        {
            get { return _flyOutIsOpen; }

            set
            {
                if (_flyOutIsOpen == value)
                {
                    return;
                }

                _flyOutIsOpen = value;
                RaisePropertyChanged(nameof(FlyOutIsOpen));
            }
        }
        #endregion

        public MainViewModel()
        {
            TrainsDictionary = new Dictionary<TrainUI, SRT.TrainObserverServiceClient>();
            Trains=new ObservableCollection<TrainUI>();
            
        }

        private RelayCommand _openCloseStartSettingCommand;
        public RelayCommand OpenCloseStartSettings
        {
            get
            {
                return _openCloseStartSettingCommand
                       ?? (_openCloseStartSettingCommand = new RelayCommand(
                           () =>
                           {
                               FlyOutIsOpen = !FlyOutIsOpen;
                           }));
            }
        }

        private RelayCommand _connectToTrainCommand;
        public RelayCommand ConnectToTrainCommand
        {
            get
            {
                return _connectToTrainCommand
                       ?? (_connectToTrainCommand = new RelayCommand(
                           () =>
                           {
                               try
                               {
                                   InstanceContext context = new InstanceContext(this);
                                   tempProxy = new SRT.TrainObserverServiceClient(context);

                                   string servicePath = tempProxy.Endpoint.ListenUri.AbsolutePath;

                                   tempProxy.Endpoint.Address = new EndpointAddress($"net.tcp://{IpAdress}:{PortAdress}{servicePath}");

                                   tempProxy.Open();

                                   tempProxy.ConnectAsync();
                                   tempProxy.ConnectCompleted += Proxy_ConnectCompletedAsync;
                               }
                               catch (Exception ex)
                               {
                                   //(ex.Message);
                               }
                           }));
            }
        }

        private RelayCommand<TrainUI> _disconnectTrain;
        public RelayCommand<TrainUI> DisconnectTrain
        {
            get
            {
                return _disconnectTrain
                       ?? (_disconnectTrain = new RelayCommand<TrainUI>(
                           param =>
                           {
                               TrainsDictionary[param].DisconnectAsync();
                               TrainsDictionary.Remove(param);
                               Trains.Remove(param);
                           }));
            }
        }

        private async void Proxy_ConnectCompletedAsync(object sender, ConnectCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //Message(e.Error.Message);
            }
            else if (e.Result)
            {
                HandleProxy();
            }
            else if (!e.Result)
            {
               // Message("Name found");
            }
        }

        private void HandleProxy()
        {
            switch (tempProxy.State)
            {
                case CommunicationState.Closed:
                    tempProxy = null;
                    //Message("Dissconnected");
                    break;
                case CommunicationState.Faulted:
                    tempProxy.Abort();
                    tempProxy = null;
                    //Message("Dissconnected");
                    break;
                case CommunicationState.Opened:
                    
                    tempProxy.GetTrainInfoAsync();
                    break;
                default:
                    break;

            }
        }

        public void ReciveTrainInfo(TrainInfo info)
        {
            if (TrainsDictionary.Keys.FirstOrDefault(a => a.Name == info.BaseTrain.Number) == null && tempProxy!=null)
            {
                var train = new TrainUI
                {
                    Name = info.BaseTrain.Number,
                    Location = info.TrainPosition,
                    PassangersCount = info.BaseTrain.CurrentPassengers,
                    Speed = int.Parse(info.BaseTrain.Speed.ToString())
                };
               TrainsDictionary.Add(train, tempProxy);
                Trains.Add(train);
                tempProxy = null;
            }
        }

        public IAsyncResult BeginReciveTrainInfo(TrainInfo info, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndReciveTrainInfo(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }
}