using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Popup.Episode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupAddEpisode : PopupPage
    {
        public PopupAddEpisode(string message)
        {
            InitializeComponent();
            label1.Text = message;
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
