using System.Runtime.Serialization;

namespace MetroSimulation.Train
{
    [DataContract]
    public class Train
    {
        [DataMember]
        public int MaxPassengers { get; private set; }

        [DataMember]
        public string Number
        {
            get { return _trainNumber; }
        }
        [DataMember]
        public float Speed
        {
            get { return _speed; }
        }
        [DataMember]
        public int CurrentPassengers
        {
            get { return _currentPassengers; }
        }

        public void SetPassengers(int passengers)
        {
            _currentPassengers = passengers;
        }

        public Train(string trainNumber, float speed, int maxPassengers)
        {
            _trainNumber = trainNumber;
            _speed = speed;
            MaxPassengers = maxPassengers;
            _currentPassengers = 0;
        }

        private string _trainNumber;
        private float  _speed;
        private int    _currentPassengers;
    }
}
