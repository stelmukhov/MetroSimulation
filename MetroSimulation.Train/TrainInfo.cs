using System.Runtime.Serialization;

namespace MetroSimulation.Train
{
    [DataContract]
    public class TrainInfo
    {
        [DataMember]
        public Train  BaseTrain { get; set; }
        [DataMember]
        public string TrainPosition { get; set;}

        public TrainInfo(string trainNumber, float speed, int maxPassengers)
        {
            TrainPosition = "In depo";
            BaseTrain = new Train(trainNumber, speed, maxPassengers);
        }
    }
}
