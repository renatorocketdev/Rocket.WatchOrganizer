using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rocket.WatchOrganizer.Core.ViewModels.Series;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class AddSeriePage : MvxContentPage<AddSerieViewModel>
    {
        public AddSeriePage()
        {
            InitializeComponent();
        }
    }
}
