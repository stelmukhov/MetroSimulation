using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroSimulation.TrainStation
{
    public class MetroTunnel : Station
    {
        public MetroTunnel(string name, double tunnelDelay)
            :base(1, name, tunnelDelay)
        {
            trains = new List<string>(1);
            topLine = new List<string>(2);
            bottomLine = null;
        }

        public string InStation
        {
            get { return topLine.ElementAt(0); }
            set { topLine[0] = value; }
        }

        public string OutStation
        {
            get { return topLine.ElementAt(1); }
            set { topLine[1] = value; }
        }

        public string TrainInTunnel
        {
            get { return trains.ElementAt(0); }
            set { trains[0] = value; }
        }
       

    }
}
