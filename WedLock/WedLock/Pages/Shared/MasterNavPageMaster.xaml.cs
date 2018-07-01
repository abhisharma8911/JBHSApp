using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Shared
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterNavPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterNavPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterNavPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterNavPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterNavPageMenuItem> MenuItems { get; set; }
            public string UserName = "Ishwardeep";
            public MasterNavPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterNavPageMenuItem>(new[]
                {
                    new MasterNavPageMenuItem { Id = 0, Title = "Home", TargetType=typeof(Profile.Home) },
                    new MasterNavPageMenuItem { Id = 1, Title = "Profile",TargetType=typeof(Profile.ProfilePage) },
                   // new MasterNavPageMenuItem { Id = 2, Title = "Photos",TargetType=typeof(Profile.Photos) },
                    //new MasterNavPageMenuItem { Id = 3, Title = "Page 4" },
                    //new MasterNavPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}