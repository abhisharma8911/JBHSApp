﻿using Xamarin.Forms;

using WedLock.Pages.Account;
using WedLock.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using WedLock.Pages.Shared;
using WedLock.Pages.Profile;

namespace WedLock
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        public App()
        {
            InitializeComponent();

            var nav = new NavigationService();
            configurenavpages(nav);
            if (!SimpleIoc.Default.IsRegistered<NavigationService>())
                SimpleIoc.Default.Register<NavigationService>(() => nav);

            var firstPage = GetMainPage();
            nav.Initialize(firstPage);
            MainPage = firstPage;
            //MainPage = new Pages.Profile.UserMessagePage();
        }

        public static NavigationPage GetMainPage()
        {
            return new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        static void configurenavpages(NavigationService nav)
        {
            #region Account
            nav.Configure(ViewModelLocator.HomePage, typeof(HomePage));
            nav.Configure(ViewModelLocator.LoginPage, typeof(LoginPage));
            nav.Configure(ViewModelLocator.RegisterPage, typeof(RegisterPage));
            nav.Configure(ViewModelLocator.ForgotPasswordPage, typeof(ForgotPasswordPage));
            #endregion

            #region Shared
            nav.Configure(ViewModelLocator.MasterNavPage, typeof(MasterNavPage));
            #endregion

            #region Profile
            nav.Configure(ViewModelLocator.ProfilePage, typeof(ProfilePage));
            nav.Configure(ViewModelLocator.PhotosPage, typeof(PhotosPage));
            nav.Configure(ViewModelLocator.SearchMatchPage, typeof(SearchPage));
            nav.Configure(ViewModelLocator.AccountDetailsPage, typeof(AccountDetailsPage));
            nav.Configure(ViewModelLocator.MessagesPage, typeof(MessagesPage));
            nav.Configure(ViewModelLocator.ContactsPage, typeof(ContactsPage));
            nav.Configure(ViewModelLocator.ReferredPage, typeof(ReferredPage));
            nav.Configure(ViewModelLocator.RequestsPage, typeof(RequestsPage));
            nav.Configure(ViewModelLocator.Dashboard, typeof(Dashboard));
            nav.Configure(ViewModelLocator.UserMessagePage, typeof(UserMessagePage));
            #endregion
        }

    }
}
