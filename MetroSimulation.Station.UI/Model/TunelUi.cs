using System;
using GalaSoft.MvvmLight;

namespace MetroSimulation.Station.UI.Model
{
    public class TunelUi :ViewModelBase
    {
        private string _ipAdress = String.Empty;
        public string Ip
        {
            get { return _ipAdress; }

            set
            {
                if (_ipAdress == value)
                {
                    return;
                }

                _ipAdress = value;
                RaisePropertyChanged(nameof(Ip));
            }
        }

        private string _port = string.Empty;
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
    }
}