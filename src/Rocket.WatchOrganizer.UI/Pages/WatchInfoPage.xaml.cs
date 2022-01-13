using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rocket.WatchOrganizer.Core.ViewModels.WatchList;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false)]
    public partial class WatchInfoPage : MvxContentPage<WatchInfoPageViewModel>
    {
        public WatchInfoPage()
        {
            InitializeComponent();
        }
    }
}
