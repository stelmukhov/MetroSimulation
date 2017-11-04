using System.ServiceModel;

namespace MetroSimulation.Train.Service
{
    [ServiceContract]
    internal interface IObserverCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReciveTrainInfo(TrainInfo info);
    }
}