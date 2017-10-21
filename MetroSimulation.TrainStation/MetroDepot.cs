using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroSimulation.TrainStation
{
    public class MetroDepot : Station
    {
        public MetroDepot(string name, double depotDelay)
            :base (10, name, depotDelay)
        {
            trains = new List<string>(10);
            topLine = new List<string>(1);
            bottomLine = new List<string>(1);
        }


        public void AddTrain(string train)
        {
            trains.Add(train);
        }

        public IEnumerable<string> TrainsInDepot
        {
            get { return trains; }
        }

        public string OutTunnel
        {
            get { return bottomLine.ElementAt(0); }
            set { bottomLine[0] = value; }
        }

        public string InTunnel
        {
            get { return topLine.ElementAt(0); }
            set { topLine[0] = value; }
        }
    }
}
