using Prism.Navigation;

namespace Taxi_cf.Prism.ViewModels
{
    public class GroupPageViewModel : ViewModelBase
    {
        public GroupPageViewModel(
            INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Admin my family group";
        }
    }
}
