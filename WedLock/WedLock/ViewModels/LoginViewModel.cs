using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace WedLock.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private INavigationService _navService;
        public LoginViewModel(INavigationService navService)
        {
            _navService = navService;
        }
    }
}
