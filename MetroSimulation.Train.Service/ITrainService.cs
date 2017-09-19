using System.ServiceModel;

namespace MetroSimulation.Train.Service
{
    [ServiceKnownType(typeof(Train))]
    [ServiceContract]
    public interface ITrainService
    {
        [OperationContract]
        Train GetTrainInfo();

        [OperationContract]
        string GetTrainPosition();

        [OperationContract]
        void SetTrainPosition(string possition);

        [OperationContract]
        void SetPassengers(int passengers);
    }
}
