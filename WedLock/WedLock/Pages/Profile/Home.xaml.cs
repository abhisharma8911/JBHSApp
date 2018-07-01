﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WedLock.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private HomeViewModel viewModel = App.Locator.HomeViewModel;
        public Home()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}