using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroSimulation.TrainStation
{
    public abstract class Station
    {
        public string Name { get; set; }

        public Station (int countOfTrainInStation, string name, double stationDelay)
        {
            _countOfTrainInStation = countOfTrainInStation;
            Name = name;
            _stationDelay = stationDelay;
        }

        public int CountOfTrainInStation
        {
            get { return _countOfTrainInStation; }
        }

        public double DelayStation
        {
            get { return _delayStation; }
        }


        private int _countOfTrainInStation;
        private double _stationDelay;

        protected List<string> trains;
        protected List<string> topLine;
        protected List<string> bottomLine;
    }
}
