using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;
using System.Linq;
using System;
using System.Collections.ObjectModel;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep3ViewModel : BaseViewModel<Season, Season>
    {
        #region Properties

        private Season _season;
        public Season Season
        {
            get => _season;
            set
            {
                _season = value;
                RaisePropertyChanged(() => Season);
            }
        }

        #endregion

        private readonly IMvxNavigationService _navigationService;
        private readonly EpisodeService _service;

        public WatchedStep3ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            if (_service == null)
            {
                _service = new EpisodeService();
            }
        }

        public override void Prepare(Season season)
        {
            _season = season;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            GetSeasonListAsync();
        }

        private void GetSeasonListAsync()
        {
            var episodes = new ObservableCollection<Episode>();

            for (var i = 1; i <= 10; i++)
            {
                episodes.Add(new Episode { Titulo = "Episódio " + i });
            }

            _season.Episodes = episodes;
        }

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());
        public async Task BackNavigationAsync()
        {
            if (IsListEpisodesValid())
            {
                await _navigationService.Close(this, _season);
            }
        }

        private bool IsListEpisodesValid()
        {
            return _season.Episodes.Count > 0;
        }

        public IMvxCommand<Episode> DeleteEpisodeCommand => new MvxCommand<Episode>((episode) => DeleteEpisode(episode));
        public void DeleteEpisode(Episode episode)
        {
            _season.Episodes.Remove(episode);
        }

        public IMvxAsyncCommand CheckCommand => new MvxAsyncCommand(async () => await CheckCommandAsync());
        public async Task CheckCommandAsync()
        {
            //Validação
        }
    }
}
