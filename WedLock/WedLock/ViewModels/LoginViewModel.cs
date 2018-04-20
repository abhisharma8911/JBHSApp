using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace WedLock.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
       public RelayCommand ForgotPasswordCommand => new RelayCommand(ForgotPassword_clicked);

       public void ForgotPassword_clicked()
        {
            _navigationService.NavigateTo(ViewModelLocator.ForgotPasswordPage);
        }
    }
}
