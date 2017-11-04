using System.ServiceModel;

namespace MetroSimulation.Train.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        IncludeExceptionDetailInFaults = true,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        UseSynchronizationContext = false)]
    public class TrainService : ITrainObserverService
    {
        private IObserverCallback Observer { get; set; }
        IObserverCallback CurrentObserverCallback => OperationContext.Current.
            GetCallbackChannel<IObserverCallback>();

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

        public bool Connect()
        {
            if (Observer == null)
            {
                Observer = CurrentObserverCallback;
                return true;
            }
            return false;
        }

        public void GetTrainInfo()
        {
            Observer.ReciveTrainInfo(_baseTrainInfo);
        }

        public void SetPassengers(int passengers)
        {
            _baseTrainInfo.BaseTrain.SetPassengers(passengers);
        }

        public void Disconnect()
        {
            Observer = null;
        }


        private TrainInfo _baseTrainInfo;
    }
}
