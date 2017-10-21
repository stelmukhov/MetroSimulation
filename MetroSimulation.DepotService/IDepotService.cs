using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetroSimulation.DepotService
{
    
    [ServiceContract]
    public interface IDepotService
    {
        [OperationContract]
        string GetDepotName();

        [OperationContract]
        void SetDepotName(string name);

        [OperationContract]
        void SetTrain(string train);

        [OperationContract]
        IEnumerable<string> TrainsInDepot();

        [OperationContract]
        void SetInTunnel(string inTunnel);

        [OperationContract]
        string GetInTunnel();

        [OperationContract]
        void SetOutTunnel(string outTunnel);

        [OperationContract]
        string GetOutTunnel();

        [OperationContract]
        double GetDepotDelay();
        
    }
}
