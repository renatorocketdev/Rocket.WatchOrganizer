using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace Rocket.WatchOrganizer.UI.Popup.Season
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupAddSeason : PopupPage
    {
        public event PropertyChangedEventHandler Propertychanged;
        public event EventHandler<object> CallbackEvent;

        public PopupAddSeason(string message)
        {
            InitializeComponent();
            label1.Text = message;
            LblText = "teste";
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

        public Core.Models.Season Season { get; set; }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            CallbackEvent?.Invoke(this, Season);

            Season = new Core.Models.Season
            {
                Titulo = LblText
            };

            await PopupNavigation.Instance.PopAsync();
        }

        private string _lblText;
        public string LblText
        {
            get => _lblText;
            set
            {
                _lblText = value;
                OnPropertyChanged();
            }
        }
    }
}
