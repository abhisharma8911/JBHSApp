using WedLock.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Account
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.RegisterViewModel;
        }
    }
}