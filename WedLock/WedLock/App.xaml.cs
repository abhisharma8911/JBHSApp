﻿using Xamarin.Forms;

using WedLock.Pages.Account;
using WedLock.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

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

            #region Account
            nav.Configure(ViewModelLocator.HomePage, typeof(HomePage));
            nav.Configure(ViewModelLocator.Login, typeof(LoginPage));
            #endregion

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
                SimpleIoc.Default.Register<INavigationService>(() => nav);

            var firstPage = GetMainPage();
            nav.Initialize(firstPage);
            MainPage = firstPage;
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
    }
}
