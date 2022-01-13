using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rocket.WatchOrganizer.Core.ViewModels.Home;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false)]
    public partial class HomePage : MvxContentPage<HomeViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }
}
