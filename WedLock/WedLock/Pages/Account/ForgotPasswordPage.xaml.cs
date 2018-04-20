﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WedLock.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Account
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPasswordPage : ContentPage
	{
        public ForgotPasswordViewModel viewmodel = new ForgotPasswordViewModel();
		public ForgotPasswordPage ()
		{
			InitializeComponent ();
            BindingContext = viewmodel;

        }
	}
}