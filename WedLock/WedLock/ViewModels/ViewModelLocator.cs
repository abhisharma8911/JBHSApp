using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;


namespace WedLock.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            #region Account
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<RegisterViewModel>();
            SimpleIoc.Default.Register<ForgotPasswordViewModel>();
            #endregion
            #region Profile
            
            SimpleIoc.Default.Register<AccountDetailsPageViewModel>();
            SimpleIoc.Default.Register<DashboardViewModel>();
            SimpleIoc.Default.Register<ContactsPageViewModel>();
            SimpleIoc.Default.Register<MessagesPageViewModel>();
            SimpleIoc.Default.Register<ProfilePageViewModel>();
            SimpleIoc.Default.Register<ReferredPageViewModel>();
            SimpleIoc.Default.Register<RequestsPageViewModel>();
            SimpleIoc.Default.Register<SearchPageViewModel>();
            SimpleIoc.Default.Register<UserMessagePageViewModel>();
            SimpleIoc.Default.Register<PhotosPageViewModel>();
            #endregion
        }

        public const string MasterNavPage = "MasterNavPage";

        #region Account

        public const string HomePage = "HomePage";
        public const string LoginPage = "LoginPage";
        public const string RegisterPage = "RegisterPage";
        public const string ForgotPasswordPage = "ForgotPasswordPage";

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();
        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public RegisterViewModel RegisterViewModel => ServiceLocator.Current.GetInstance<RegisterViewModel>();
        public ForgotPasswordViewModel ForgotPasswordViewModel => ServiceLocator.Current.GetInstance<ForgotPasswordViewModel>();
        #endregion

        #region Profile

        public const string ProfilePage = "ProfilePage";
        public const string PhotosPage = "PhotosPage";
        public const string SearchMatchPage = "SearchMatchPage";
        public const string AccountDetailsPage = "AccountDetailsPage";
        public const string MessagesPage = "MessagesPage";
        public const string ContactsPage = "ContactsPage";
        public const string ReferredPage = "ReferredPage";
        public const string RequestsPage = "RequestsPage";
        public const string UserMessagePage = "UserMessagePage";
        public const string Dashboard = "Dashboard";


        public AccountDetailsPageViewModel AccountDetailsPageViewModel => ServiceLocator.Current.GetInstance<AccountDetailsPageViewModel>();
        public DashboardViewModel DashboardViewModel => ServiceLocator.Current.GetInstance<DashboardViewModel>();
        public ContactsPageViewModel ContactsPageViewModel => ServiceLocator.Current.GetInstance<ContactsPageViewModel>();
        public MessagesPageViewModel MessagesPageViewModel => ServiceLocator.Current.GetInstance<MessagesPageViewModel>();
        public ProfilePageViewModel ProfilePageViewModel => ServiceLocator.Current.GetInstance<ProfilePageViewModel>();
        public PhotosPageViewModel PhotosPageViewModel => ServiceLocator.Current.GetInstance<PhotosPageViewModel>();
        public ReferredPageViewModel ReferredPageViewModel => ServiceLocator.Current.GetInstance<ReferredPageViewModel>();
        public RequestsPageViewModel RequestsPageViewModel => ServiceLocator.Current.GetInstance<RequestsPageViewModel>();
        public SearchPageViewModel SearchPageViewModel => ServiceLocator.Current.GetInstance<SearchPageViewModel>();
        public UserMessagePageViewModel UserMessagePageViewModel => ServiceLocator.Current.GetInstance<UserMessagePageViewModel>();
        
        #endregion


    }
}
