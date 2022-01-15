using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rg.Plugins.Popup.Services;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;
using Rocket.WatchOrganizer.UI.Popup;
using Rocket.WatchOrganizer.UI.Popup.Season;
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
            await OpenDeletePopupAsync();
        }
        public async Task OpenPopupAsync()
        {
            var page = new PopupAddSeason("Adicionar Temporada");
            page.CallbackEvent += (object sender, object e) => CallbackMethod(sender, e);
            await PopupNavigation.Instance.PushAsync(page);
        }

        private void CallbackMethod(object sender, object e)
        {
            ViewModel.Serie.Banner = e.ToString();
        }

        public async Task OpenEditPopupAsync()
        {
            var page = new PopupAddSeason("Editar Temporada");
            await PopupNavigation.Instance.PushAsync(page);
        }
        public async Task OpenDeletePopupAsync()
        {
            var page = new DefaultPopup("Deletar Temporada");
            await PopupNavigation.Instance.PushAsync(page);
        }
    }
}
