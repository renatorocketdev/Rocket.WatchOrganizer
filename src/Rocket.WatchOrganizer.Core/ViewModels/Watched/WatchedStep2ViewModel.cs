using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep2ViewModel : BaseViewModel<Serie>
    {
        #region Properties

        private Serie _serie;
        public Serie Serie
        {
            get => _serie;
            set
            {
                _serie = value;
                RaisePropertyChanged(() => Serie);
            }
        }

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

        private MvxInteraction<Season> _interaction =
            new MvxInteraction<Season>();

        // need to expose it as a public property for binding (only IMvxInteraction is needed in the view)
        public IMvxInteraction<Season> Interaction => _interaction;

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

        public override void Prepare(Serie serie)
        {
            _serie = serie;
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

        public IMvxAsyncCommand AddSeasonCommand => new MvxAsyncCommand(async () => await AddSeasonAsync());
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

        }

        private async Task AddSeasonAsync()
        {
            var result = await Mvx.IoCProvider.Resolve<IUserDialogs>().PromptAsync("Título Temporada");
        }
    }
}
