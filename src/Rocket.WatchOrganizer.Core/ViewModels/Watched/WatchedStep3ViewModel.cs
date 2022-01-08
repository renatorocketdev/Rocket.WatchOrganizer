using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep3ViewModel : BaseViewModel
    {
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
        public override async Task Initialize()
        {
            await base.Initialize();
            GetSeasonListAsync();
        }

        private void GetSeasonListAsync()
        {
            Episodes = new List<Episode>
            {
                new Episode
                {
                    Titulo = "Episode 1",
                },
                new Episode
                {
                    Titulo = "Episode 2",
                },
                new Episode
                {
                    Titulo = "Episode 3",
                },
                new Episode
                {
                    Titulo = "Episode 4",
                }
            };
        }

        #region Properties

        private List<Episode> _episodes;
        public List<Episode> Episodes
        {
            get => _episodes;
            set
            {
                _episodes = value;
                RaisePropertyChanged(() => Episodes);
            }
        }
        #endregion

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public IMvxAsyncCommand CheckCommand => new MvxAsyncCommand(async () => await CheckCommandAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }
        public async Task CheckCommandAsync()
        {
            //Validação
        }
    }
}
