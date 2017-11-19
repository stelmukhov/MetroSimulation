using System;
using System.Linq;
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
                _baseTrainInfo.TrainPosition=trainPosition;
            }
        }


        public string GetTrainPosition()
        {
            return _baseTrainInfo.TrainPosition;
        }

        public void SetTrainPosition(string possition)
        {
            _baseTrainInfo.TrainPosition=(possition);
        }

        public bool Connect()
        {
                Observer = CurrentObserverCallback;
                return true;
        }

        public void GetTrainInfo()
        {
            Observer.ReciveTrainInfo(_baseTrainInfo);
        }

        public void SetPassengers(int passengers)
        {
            _baseTrainInfo.BaseTrain.CurrentPassengers=(passengers);
        }

        public void Disconnect()
        {
            Observer = null;
        }


        private TrainInfo _baseTrainInfo=new TrainInfo($"{RandomString(3)}-{random.Next(0,999)}",100,400);
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
