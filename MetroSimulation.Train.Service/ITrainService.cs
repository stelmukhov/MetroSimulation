using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.ServiceModel;

namespace MetroSimulation.Train.Service
{
    [ServiceContract(CallbackContract = typeof(IObserverCallback),
        SessionMode = SessionMode.Required)]
    public interface ITrainObserverService
    {
        [OperationContract]
        bool Connect();
        [OperationContract(IsOneWay = false)]
        void GetTrainInfo();
        [OperationContract(IsOneWay = false)]
        string GetTrainPosition();
        [OperationContract(IsOneWay = true)]
        void SetTrainPosition(string possition);
        [OperationContract(IsOneWay = true)]
        void SetPassengers(int passengers);

        [OperationContract(IsOneWay = true)]
        void Disconnect();
    }
}
