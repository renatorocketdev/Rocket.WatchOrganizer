using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Rg.Plugins.Popup.Services;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;
using Rocket.WatchOrganizer.UI.Popup;
using Rocket.WatchOrganizer.UI.Popup.Episode;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false)]
    public partial class WatchedStep3Page : MvxContentPage<WatchedStep3ViewModel>
    {
        public WatchedStep3Page()
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
            var page = new PopupAddEpisode("Adicionar Episódio");
            await PopupNavigation.Instance.PushAsync(page);
        }

        public async Task OpenEditPopupAsync()
        {
            var page = new PopupAddEpisode("Editar Episódio");
            await PopupNavigation.Instance.PushAsync(page);
        }
        public async Task OpenDeletePopupAsync()
        {
            var page = new DefaultPopup("Deletar Episódio");
            await PopupNavigation.Instance.PushAsync(page);
        }
    }
}
