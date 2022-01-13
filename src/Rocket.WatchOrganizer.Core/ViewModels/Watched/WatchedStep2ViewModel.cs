using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rg.Plugins.Popup.Services;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep2ViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly SeasonService _service;

        public WatchedStep2ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            if (_service == null)
            {
                _service = new SeasonService();
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            GetSeasonListAsync();
        }

        public void GetSeasonListAsync()
        {
            Seasons = new List<Season>
            {
                new Season
                {
                    Titulo = "Temporada 1", 
                },
                new Season
                {
                    Titulo = "Temporada 2",
                },
                new Season
                {
                    Titulo = "Temporada 3",
                },
                new Season
                {
                    Titulo = "Temporada 4",
                }
            };
        }

        #region Properties

        private List<Season> _seasons;
        public List<Season> Seasons
        {
            get => _seasons;
            set
            {
                _seasons = value;
                RaisePropertyChanged(() => Seasons);
            }
        }
        #endregion

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public IMvxAsyncCommand ShowAddEpisodeCommand => new MvxAsyncCommand(async () => await ShowAddEpisodeAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }
        public async Task ShowAddEpisodeAsync()
        {
            await _navigationService.Navigate<WatchedStep3ViewModel>();
        }

        public async Task OpenPopupAsync()
        {
            //await PopupNavigation.Instance.PushAsync(new PopupAddSeason);
        }

    }
}
