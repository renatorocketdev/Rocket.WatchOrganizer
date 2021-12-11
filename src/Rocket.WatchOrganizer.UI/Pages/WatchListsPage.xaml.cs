using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rocket.WatchOrganizer.Core.ViewModels.WatchList;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class WatchListPage : MvxContentPage<WatchListViewModel>
    {
        public WatchListPage()
        {
            InitializeComponent();
        }
    }
}
