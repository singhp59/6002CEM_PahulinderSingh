using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FitnessTrackerApp.ViewModels
{
    public class WorkoutLogViewModel : BaseViewModel
    {
        public ObservableCollection<string> Workouts { get; set; }
        public string SelectedWorkoutType { get; set; }
        public int Duration { get; set; }

        public ICommand LogWorkoutCommand { get; }

        public WorkoutLogViewModel()
        {
            Workouts = new ObservableCollection<string>();
            LogWorkoutCommand = new Command(LogWorkout);
        }

        private void LogWorkout()
        {
            if (!string.IsNullOrEmpty(SelectedWorkoutType) && Duration > 0)
            {
                Workouts.Add($"{SelectedWorkoutType} - {Duration} min");
                OnPropertyChanged(nameof(Workouts));
            }
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseViewModel
    {
    }
}
