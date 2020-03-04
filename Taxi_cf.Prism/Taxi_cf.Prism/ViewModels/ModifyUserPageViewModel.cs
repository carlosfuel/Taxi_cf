using Prism.Navigation;

namespace Taxi_cf.Prism.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase
    {
        public ModifyUserPageViewModel(
            INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Modify User";
        }
    }
}
