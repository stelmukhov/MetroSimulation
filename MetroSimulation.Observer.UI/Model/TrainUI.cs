using System;
using GalaSoft.MvvmLight;

namespace MetroSimulation.Observer.UI.Model
{
    public class TrainUI :ViewModelBase
    {
        public int IP { get; set; }

        private string _name = String.Empty;
        public string Name
        {
            get => _name;

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

        private string _location = String.Empty;
        public string Location
        {
            get { return _location; }

            set
            {
                if (_location == value)
                {
                    return;
                }

                _location = value;
                RaisePropertyChanged(nameof(Location));
            }
        }

        private int _speed = 0;
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

        private int _passangersCount = 0;
        public int PassangersCount
        {
            get { return _passangersCount; }

            set
            {
                if (_passangersCount == value)
                {
                    return;
                }

                _passangersCount = value;
                RaisePropertyChanged(nameof(PassangersCount));
            }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                RaisePropertyChanged(nameof(Color));
            }
        }

        public string Color => _isActive?"green":"red";
    }
}