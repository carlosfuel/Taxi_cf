using Prism.Navigation;

namespace Taxi_cf.Prism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(
            INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login";
        }
    }
}
