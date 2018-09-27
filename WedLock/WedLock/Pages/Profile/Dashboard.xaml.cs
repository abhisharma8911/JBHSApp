using System;
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
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            BindingContext = App.Locator.DashboardViewModel;
        }
    }
}