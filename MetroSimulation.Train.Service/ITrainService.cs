namespace MetroSimulation.Train.Service
{
    public interface ITrainService
    {
        Train GetTrainInfo();

        string GetTrainPosition();

        void SetTrainPosition(string possition);

        void SetPassengers(int passengers);
    }
}
