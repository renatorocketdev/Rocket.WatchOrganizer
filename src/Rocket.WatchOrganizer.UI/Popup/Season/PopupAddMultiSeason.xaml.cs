using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Popup.Season
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupAddMultiSeason : PopupPage
    {
        public PopupAddMultiSeason()
        {
            InitializeComponent();
        }

        // Invoked when a hardware back button is pressed
        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }

        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }

        private async void Cancel_ButtonAsync(object sender, System.EventArgs e)
        {
            await ClosePopupAsync();
        }
        public async Task ClosePopupAsync()
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}
