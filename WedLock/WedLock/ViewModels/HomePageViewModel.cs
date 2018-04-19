using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace WedLock.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        public HomePageViewModel(INavigationService navService)
        {
            _navigationService = navService;
        }

        public RelayCommand LoginCommand => new RelayCommand(NavtoLoginPage);

        private void NavtoLoginPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.Login);
        }
    }
}
