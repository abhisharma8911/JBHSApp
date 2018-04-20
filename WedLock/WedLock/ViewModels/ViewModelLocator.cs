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

            //SimpleIoc.Default.Register<BaseViewModel>();
        }

        public const string HomePage = "HomePage";
        public const string LoginPage = "LoginPage";
        public const string RegisterPage = "RegisterPage";
        public const string ForgotPasswordPage = "ForgotPasswordPage";



        public HomePageViewModel HomePageViewModel => ServiceLocator.Current.GetInstance<HomePageViewModel>();
        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public RegisterViewModel RegisterViewModel => ServiceLocator.Current.GetInstance<RegisterViewModel>();
        public ForgotPasswordViewModel ForgotPasswordViewModel => ServiceLocator.Current.GetInstance<ForgotPasswordViewModel>();


    }
}
