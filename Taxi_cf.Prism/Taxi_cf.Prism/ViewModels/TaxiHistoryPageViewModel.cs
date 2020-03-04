using Prism.Navigation;

namespace Taxi_cf.Prism.ViewModels
{
    public class TaxiHistoryPageViewModel : ViewModelBase
    {
        public TaxiHistoryPageViewModel(
            INavigationService navigationService)
            : base(navigationService)
        {
            Title = "See taxi history";
        }
    }
}
