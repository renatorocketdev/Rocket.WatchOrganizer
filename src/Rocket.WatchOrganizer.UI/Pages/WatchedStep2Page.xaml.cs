using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rg.Plugins.Popup.Services;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Result;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;
using Rocket.WatchOrganizer.UI.Popup;
using Rocket.WatchOrganizer.UI.Popup.Season;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false, Animated = true)]
    public partial class WatchedStep2Page : MvxContentPage<WatchedStep2ViewModel>
    {       
        public WatchedStep2Page()
        {
            InitializeComponent();
        }

        private async void OpenPopup_ClickAsync(object sender, System.EventArgs e)
        {
           await OpenPopupAsync();
        }
        private async void OpenEditPopup_ClickAsync(object sender, System.EventArgs e)
        {
            await OpenEditPopupAsync();
        }
        private async void OpenDeletePopup_ClickAsync(object sender, System.EventArgs e)
        {
            var season = ((Button)sender).BindingContext as Season;          
            await OpenDeletePopupAsync(season);
        }
        public async Task OpenPopupAsync()
        {
            var page = new PopupAddSeason();
            page.CallbackEvent += (object sender, object e) => CallbackMethod(sender, e);
            await PopupNavigation.Instance.PushAsync(page);
        }

        private void CallbackMethod(object sender, object e)
        {
            ViewModel.Serie.Seasons.Add((e as Season));
        }

        public async Task OpenEditPopupAsync()
        {
            var page = new PopupAddSeason();
            await PopupNavigation.Instance.PushAsync(page);
        }
        public async Task OpenDeletePopupAsync(Season season)
        {
            var page = new DefaultConfirmPopup("Deseja deletar a Temporada?", 1);
            page.CallbackEvent += (object sender, object e) => CallbackConfirmPopup(sender, e);
            await PopupNavigation.Instance.PushAsync(page);
        }

        private void CallbackConfirmPopup(object sender, object e)
        {
            var result = (e as ConfirmResult);
            if (result.Result == true)
            {
                ViewModel.Serie.Seasons.Remove(result.Id as Season);
            }
        }
    }
}
