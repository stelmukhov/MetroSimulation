using System.Runtime.Serialization;

namespace MetroSimulation.Train
{
    [DataContract]
    public class TrainInfo
    {
        [DataMember]
        public Train  BaseTrain { get; private set; }
        [DataMember]
        public string TrainPosition { get; private set;}

        public TrainInfo(string trainNumber, float speed, int maxPassengers)
        {
            BaseTrain = new Train(trainNumber, speed, maxPassengers);
        }


        public void SetNewPosition(string newPosition)
        {
            TrainPosition = newPosition;
        }
    }
}
