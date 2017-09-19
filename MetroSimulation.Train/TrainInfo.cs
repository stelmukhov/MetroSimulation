namespace MetroSimulation.Train
{
    public class TrainInfo
    {
        public Train  BaseTrain { get; private set; }
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
