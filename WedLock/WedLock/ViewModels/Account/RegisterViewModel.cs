using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WedLock.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public RelayCommand AlreadyRegisteredCommand => new RelayCommand(AlreadyRegistered_Clicked);

        private void AlreadyRegistered_Clicked()
        {
            _navigationService.NavigateTo(ViewModelLocator.LoginPage);
        }

    }
}
