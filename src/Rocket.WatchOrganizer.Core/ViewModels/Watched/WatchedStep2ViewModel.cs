using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
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

        #endregion

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
            _serie.Seasons = new ObservableCollection<Season>
            {
                new Season
                {
                    IdProprio = Guid.NewGuid(),
                    Titulo = "Bem vindo ao Lar", 
                },
                new Season
                {
                    IdProprio = Guid.NewGuid(),
                    Titulo = "Longe de Casa",
                },
                new Season
                {
                    IdProprio = Guid.NewGuid(),
                    Titulo = "Sem Volta Para Casa",
                }
            };
        }

    
        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());
        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }

        public IMvxAsyncCommand<Season> ShowAddEpisodeCommand => new MvxAsyncCommand<Season>(async (season) => await ShowAddEpisodeAsync(season));
        public async Task ShowAddEpisodeAsync(Season season)
        {
            season.TituloSerie = _serie.Titulo;

            var result = await _navigationService.Navigate<WatchedStep3ViewModel, Season, Season>(season);
            if (result != null)
            {
                _serie.Seasons.Add(result);
            }
        }

        public IMvxCommand<Season> DeleteSeasonCommand => new MvxCommand<Season>((season) => DeleteSeason(season));
        public void DeleteSeason(Season season)
        {
            _serie.Seasons.Remove(season);
        }

        public async Task OpenPopupAsync()
        {
            
        }
    }
}
