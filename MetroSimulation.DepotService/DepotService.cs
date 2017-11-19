using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetroSimulation.TrainStation;

namespace MetroSimulation.DepotService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class DepotService : IDepotService
    {
        public DepotService() { }

        public DepotService(string name, double delay)
        {
            _depot = new MetroDepot(name, delay);
        }

    
        public double GetDepotDelay()
        {
            return _depot.DelayStation;
        }

        public string GetInTunnel()
        {
            return _depot.InTunnel;
        }

        public string GetOutTunnel()
        {
            return _depot.OutTunnel;
        }

        public void SetInTunnel(string inTunnel)
        {
            _depot.InTunnel = inTunnel;
        }

        public void SetOutTunnel(string outTunnel)
        {
            _depot.OutTunnel = outTunnel;
        }

        public void SetTrain(string train)
        {
            ((List<string>)_depot.TrainsInDepot).Add(train);
        }

        public IEnumerable<string> TrainsInDepot()
        {
            return _depot.TrainsInDepot;
        }

        public void SetDepotName(string name)
        {
            _depot.Name = name;
        }

        public string GetDepotName()
        {
            return _depot.Name;
        }


        private MetroDepot _depot;
    }
}
