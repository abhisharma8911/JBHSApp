using WedLock.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomePageViewModel viewModel = App.Locator.HomePageViewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}