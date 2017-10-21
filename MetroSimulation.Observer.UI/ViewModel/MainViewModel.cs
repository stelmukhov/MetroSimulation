using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using MetroSimulation.Observer.UI.Model;
using GalaSoft.MvvmLight.CommandWpf;

namespace MetroSimulation.Observer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Train> Trains { get; set; }

        public MainViewModel()
        {
            Trains=new ObservableCollection<Train>();
            Trains.Add(new Train{Name = "OVA-123",Location = "Победа - Алексеевка",PassangersCount = 210,Speed = 80});
        }

        private RelayCommand _connectToTrainCommand;
        public RelayCommand ConnectToTrainCommand
        {
            get
            {
                return _connectToTrainCommand
                       ?? (_connectToTrainCommand = new RelayCommand(
                           () =>
                           {
                               Random rand=new Random();
                               Trains.Add(
                                   new Train
                                   {
                                       Name = $"OVA-{rand.Next(999)}",
                                       Location = "Победа",
                                       PassangersCount = rand.Next(50,450),
                                       Speed = rand.Next(30,150)
                                   });
                           }));
            }
        }
    }
}