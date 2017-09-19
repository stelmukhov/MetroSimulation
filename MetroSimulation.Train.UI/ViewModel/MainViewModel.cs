using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MetroSimulation.Train.UI.Model;
using System.Collections.ObjectModel;

namespace MetroSimulation.Train.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private bool _isStartActive = true;

        public bool IsStartActive
        {
            get { return _isStartActive; }

            set
            {
                if (_isStartActive == value)
                {
                    return;
                }

                _isStartActive = value;
                RaisePropertyChanged(nameof(IsStartActive));
            }
        }

        private bool _isStopActive = false;

        public bool IsStopActive
        {
            get { return _isStopActive; }

            set
            {
                if (_isStopActive == value)
                {
                    return;
                }

                _isStopActive = value;
                RaisePropertyChanged(nameof(IsStopActive));
            }
        }

        private string _listenIp = "localhost";

        public string ListenIp
        {
            get { return _listenIp; }

            set
            {
                if (_listenIp == value)
                {
                    return;
                }

                _listenIp = value;
                RaisePropertyChanged(nameof(ListenIp));
            }
        }

        private string _port = "7997";

        public string Port
        {
            get { return _port; }

            set
            {
                if (_port == value)
                {
                    return;
                }

                _port = value;
                RaisePropertyChanged(nameof(Port));
            }
        }

        public const string NamePropertyName = "Name";
        private string _name = String.Empty;
        public string Name
        {
            get { return _name; }

            set
            {
                if (_name == value)
                {
                    return;
                }

                _name = value;
                RaisePropertyChanged(NamePropertyName);
            }
        }

        private int _speed = 50;
        public int Speed
        {
            get { return _speed; }

            set
            {
                if (_speed == value)
                {
                    return;
                }

                _speed = value;
                RaisePropertyChanged(nameof(Speed));
            }
        }

        private int _capacity = 300;
        public int Capacity
        {
            get { return _capacity; }

            set
            {
                if (_capacity == value)
                {
                    return;
                }

                _capacity = value;
                RaisePropertyChanged(nameof(Capacity));
            }
        }

        private ObservableCollection<LogMessage> _log = new ObservableCollection<LogMessage>();

        public ObservableCollection<LogMessage> Log
        {
            get { return _log; }

            set
            {
                if (_log == value)
                {
                    return;
                }

                _log = value;
                RaisePropertyChanged(nameof(Log));
            }
        }

        private RelayCommand _startButtonCommand;

        public RelayCommand StartButton
        {
            get
            {
                return _startButtonCommand
                       ?? (_startButtonCommand = new RelayCommand(async () =>
                       {

                           ///TODO
                       }));
            }
        }

        private RelayCommand _stopButtonCommand;

        public RelayCommand StopButton
        {
            get
            {
                return _stopButtonCommand
                       ?? (_stopButtonCommand = new RelayCommand(async () =>
                       {

                           //TODO
                       }));
            }
        }

        private void FailureMessage(string text)
        {
            _log.Add(LogMessage.FailureMessage(text));
        }

        private void WarningMessage(string text)
        {
            _log.Add(LogMessage.WarningMessage(text));
        }

        private void NormalMessage(string text)
        {
            _log.Add(LogMessage.NormalMessage(text));
        }

        private void SuccessMessage(string text)
        {
            _log.Add(LogMessage.SuccessMessage(text));
        }
    }
}

}
}