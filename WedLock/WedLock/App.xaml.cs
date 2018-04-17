using Xamarin.Forms;

using WedLock.Pages.Account;

namespace WedLock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //7D4F69
            MainPage = new ForgotPasswordPage();
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
