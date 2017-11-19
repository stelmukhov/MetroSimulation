using System.Runtime.Serialization;

namespace MetroSimulation.Train
{
    [DataContract]
    public class Train
    {
        [DataMember]
        public int MaxPassengers { get; private set; }

        [DataMember]
        public string Number { get; set;}
        [DataMember]
        public float Speed { get; set; }
        [DataMember]
        public int CurrentPassengers { get; set; }

        public Train(string trainNumber, float speed, int maxPassengers)
        {
            Number = trainNumber;
            Speed = speed;
            MaxPassengers = maxPassengers;
            CurrentPassengers = 0;
        }

    }
}
