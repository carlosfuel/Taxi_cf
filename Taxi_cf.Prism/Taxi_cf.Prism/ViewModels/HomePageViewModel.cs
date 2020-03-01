using Prism.Navigation;
namespace Taxi_cf.Prism.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Taxi Qualifier";
        }
    }
}
