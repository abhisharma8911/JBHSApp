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
        }

        public const string HomePage = "HomePage";
        public const string Login = "LoginPage";

        public HomePageViewModel HomePageViewModel => ServiceLocator.Current.GetInstance<HomePageViewModel>();
        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();
    }
}
