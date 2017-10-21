namespace MetroSimulation.Train.Service
{
    public class TrainService : ITrainService
    {
        public void CreateTrain(string trainNumber,
            float speed, 
            int maxPassengers,
            string trainPosition)
        {
            if (_baseTrainInfo == null)
            {
                _baseTrainInfo = new TrainInfo(trainNumber, speed, maxPassengers);
                _baseTrainInfo.SetNewPosition(trainPosition);
            }
        }

        public string GetTrainPosition()
        {
            return _baseTrainInfo.TrainPosition;
        }

        public void SetTrainPosition(string possition)
        {
            _baseTrainInfo.SetNewPosition(possition);
        }

        public Train GetTrainInfo()
        {
            return _baseTrainInfo.BaseTrain;
        }

        public void SetPassengers(int passengers)
        {
            _baseTrainInfo.BaseTrain.SetPassengers(passengers);
        }

        
        private TrainInfo _baseTrainInfo;
    }
}
