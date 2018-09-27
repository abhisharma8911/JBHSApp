using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace WedLock.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {

        public static WedLock.NavigationService _navigationService = ServiceLocator.Current.GetInstance<NavigationService>();

        public RelayCommand GoBackCommand => new RelayCommand(GoBack_Clicked);

        private void GoBack_Clicked()
        {
            _navigationService.GoBack();
        }

    }
}
