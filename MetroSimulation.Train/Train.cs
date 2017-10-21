namespace MetroSimulation.Train
{
    public class Train
    {
        public int MaxPassengers { get; private set; }

        public Train(string trainNumber, float speed, int maxPassengers)
        {
            _trainNumber = trainNumber;
            _speed = speed;
            MaxPassengers = maxPassengers;
            _currentPassengers = 0;
        }

        public string Number
        {
            get { return _trainNumber; }
        }

        public float Speed
        {
            get { return _speed; }
        }

        public int CurrentPassengers
        {
            get { return _currentPassengers; }
        }

        public void SetPassengers(int passengers)
        {
            _currentPassengers = passengers;
        }


        private string _trainNumber;
        private float  _speed;
        private int    _currentPassengers;
    }
}
