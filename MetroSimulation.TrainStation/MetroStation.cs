using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroSimulation.TrainStation
{
    public class MetroStation : Station
    {
        public MetroStation(string name, double stationDelay)
            :base(2, name, stationDelay)
        {
            trains = new List<string>(2);
            topLine = new List<string>(2);
            bottomLine = new List<string>(2);
        }

        public string TopInTunnel
        {
            get { return topLine.ElementAt(0); }
            set { topLine[0] = value; }
        }

        public string GetTopOutTunnel
        {
            get { return topLine.ElementAt(1); }
            set { topLine[1] = value; }
        }

        public string GetBottomInTunnel
        {
            get { return bottomLine.ElementAt(0); }
            set { bottomLine[0] = value; }
        }

        public string GetBottomOutTunnel
        {
            get { return bottomLine.ElementAt(1); }
            set { bottomLine[1] = value; }
            
        }


        public string TrainOnTopLine
        {
            get { return trains.ElementAt(0); }
            set { trains[0] = value; }
        }

        public string TrainOnBottomLine
        {
            get { return trains.ElementAt(1); }
            set { trains[1] = value; }
        }


        public int GeneratePasangers(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
