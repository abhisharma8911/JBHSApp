using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace WedLock.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {
        public HomeViewModel(INavigationService navService)
        {
            _navigationService = navService;
        }
        public RelayCommand ProfileCommand => new RelayCommand(NavtoProfilePage);
        public RelayCommand PhotosCommand => new RelayCommand(NavtoPhotosPage);

        public RelayCommand SearchMatchCommand => new RelayCommand(NavtoSearchMatchPage);
        public RelayCommand AccountDetailsCommand => new RelayCommand(NavtoAccountDetailsPage);

        public RelayCommand MessagesCommand => new RelayCommand(NavtoMessagesPage);
        public RelayCommand ContactsCommand => new RelayCommand(NavtoContactsPage);

        public RelayCommand ReferredCommand => new RelayCommand(NavtoReferredPage);
        public RelayCommand RequestsCommand => new RelayCommand(NavtoRequestsPage);


        private void NavtoProfilePage()
        {
            _navigationService.NavigateTo(ViewModelLocator.ProfilePage);
        }
        private void NavtoPhotosPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.PhotosPage);
        }
        private void NavtoSearchMatchPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.SearchMatchPage);
        }
        private void NavtoAccountDetailsPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.AccountDetailsPage);
        }
        private void NavtoMessagesPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.MessagesPage);
        }
        private void NavtoContactsPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.ContactsPage);
        }
        private void NavtoReferredPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.ReferredPage);
        }
        private void NavtoRequestsPage()
        {
            _navigationService.NavigateTo(ViewModelLocator.RequestsPage);
            
        }
    }
}
