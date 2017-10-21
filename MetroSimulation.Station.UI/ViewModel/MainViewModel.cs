using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MetroSimulation.Station.UI.Model;

namespace MetroSimulation.Station.UI.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public StationUi Station { get; set; }

        public TunelUi TopIn { get; set; }
        public TunelUi TopOut { get; set; }
        public TunelUi BottomIn { get; set; }
        public TunelUi BottomOut { get; set; }

        public MainViewModel()
        {
            Station = new StationUi();

            TopIn = new TunelUi();
            TopOut = new TunelUi();
            BottomIn = new TunelUi();
            BottomOut = new TunelUi();

            RaisePropertyChanged(nameof(Station));
            RaisePropertyChanged(nameof(TopIn));
            RaisePropertyChanged(nameof(TopOut));
            RaisePropertyChanged(nameof(BottomIn));
            RaisePropertyChanged(nameof(BottomOut));
        }

        private RelayCommand startServeRelayCommand;
        public RelayCommand StartServer
        {
            get
            {
                return startServeRelayCommand
                       ?? (startServeRelayCommand = new RelayCommand(
                           () =>
                           {
                               
                           }));
            }
        }

        private RelayCommand<TunelUi> connectTunelCommand;
        public RelayCommand<TunelUi> ConnectTunnel
        {
            get
            {
                return connectTunelCommand
                       ?? (connectTunelCommand = new RelayCommand<TunelUi>(
                           tunel =>
                           {
                               
                           }));
            }
        }
    }
}