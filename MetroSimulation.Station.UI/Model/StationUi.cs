using System;
using GalaSoft.MvvmLight;

namespace MetroSimulation.Station.UI.Model
{
    public class StationUi:ViewModelBase
    {
        private string _name = string.Empty;
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
                RaisePropertyChanged(nameof(Name));
            }
        }

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

        private int _minPassangers = 0;
        public int MinPassangers
        {
            get { return _minPassangers; }

            set
            {
                if (_minPassangers == value)
                {
                    return;
                }

                _minPassangers = value;
                RaisePropertyChanged(nameof(MinPassangers));
            }
        }

        private int _maxPassangers = 0;
        public int MaxPassangers
        {
            get { return _maxPassangers; }

            set
            {
                if (_maxPassangers == value)
                {
                    return;
                }

                _maxPassangers = value;
                RaisePropertyChanged(nameof(MaxPassangers));
            }
        }

        private DateTime _stopTime = new DateTime();
        public DateTime StopTime
        {
            get { return _stopTime; }

            set
            {
                if (_stopTime == value)
                {
                    return;
                }

                _stopTime = value;
                RaisePropertyChanged(nameof(StopTime));
            }
        }   

    }
}