using WedLock.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Account
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
        private RegisterViewModel viewmodel = App.Locator.RegisterViewModel;
		public RegisterPage ()
		{
			InitializeComponent ();
            BindingContext = viewmodel;
		}
	}
}