using CommonServiceLocator;

using GalaSoft.MvvmLight.Ioc;


namespace WedLock.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<HomePageViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<RegisterViewModel>();
            SimpleIoc.Default.Register<ForgotPasswordViewModel>();


            SimpleIoc.Default.Register<HomeViewModel>();

            //SimpleIoc.Default.Register<BaseViewModel>();
        }

        public const string HomePage = "HomePage";
        public const string LoginPage = "LoginPage";
        public const string RegisterPage = "RegisterPage";
        public const string ForgotPasswordPage = "ForgotPasswordPage";
        public const string MasterNavPage = "MasterNavPage";

        public const string ProfilePage = "ProfilePage";
        public const string PhotosPage = "PhotosPage";
        public const string SearchMatchPage = "SearchMatchPage";
        public const string AccountDetailsPage = "AccountDetailsPage";
        public const string MessagesPage = "MessagesPage";
        public const string ContactsPage = "ContactsPage";
        public const string ReferredPage = "ReferredPage";
        public const string RequestsPage = "RequestsPage";


        public HomePageViewModel HomePageViewModel => ServiceLocator.Current.GetInstance<HomePageViewModel>();
        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public RegisterViewModel RegisterViewModel => ServiceLocator.Current.GetInstance<RegisterViewModel>();
        public ForgotPasswordViewModel ForgotPasswordViewModel => ServiceLocator.Current.GetInstance<ForgotPasswordViewModel>();

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();
    }
}
