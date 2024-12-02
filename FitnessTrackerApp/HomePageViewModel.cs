using System.Windows.Input;

namespace FitnessTrackerApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ICommand NavigateToWorkoutLogCommand { get; }
        public ICommand NavigateToProgressCommand { get; }

        public HomePageViewModel()
        {
            NavigateToWorkoutLogCommand = new Command(async () =>
                await Shell.Current.GoToAsync("WorkoutLogPage"));
            NavigateToProgressCommand = new Command(async () =>
                await Shell.Current.GoToAsync("ProgressPage"));
        }
    }
}
