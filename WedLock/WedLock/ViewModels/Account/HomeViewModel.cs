using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace WedLock.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(NavigationService navService)
        {
            _navigationService = navService;
        }

        public RelayCommand LoginCommand => new RelayCommand(NavtoLoginPage);
        public RelayCommand RegisterCommand => new RelayCommand(NavtoRegisterPage);


        private void NavtoLoginPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.LoginPage);
        }
        private void NavtoRegisterPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.RegisterPage);
        }
    }
}
