using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WedLock.Pages.Profile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotosPage : ContentPage
	{
		public PhotosPage ()
		{
			InitializeComponent ();
            BindingContext = App.Locator.PhotosPageViewModel;
		}
	}
}