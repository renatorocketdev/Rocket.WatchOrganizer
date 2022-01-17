using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Rocket.WatchOrganizer.Core.Result;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DefaultConfirmPopup : PopupPage
    {
        public event EventHandler<object> CallbackEvent;

        public DefaultConfirmPopup(string message, int id)
        {
            InitializeComponent();
            PopupDeleteMessage = message;
            Id = id;
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
            CallbackEvent?.Invoke(this, new ConfirmResult {Id = Id, Result = false } );
            await ClosePopupAsync();
        }

        private async void Confirmar_ButtonAsync(object sender, System.EventArgs e)
        {
            CallbackEvent?.Invoke(this, new ConfirmResult { Id = Id, Result = true });
            await ClosePopupAsync();
        }

        public async Task ClosePopupAsync()
        {
            await PopupNavigation.Instance.PopAsync();
        }

        public string PopupDeleteMessage { get; set; }

        private int Id { get; set; }

    }
}
