using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;
using Rocket.WatchOrganizer.Core.ViewModels.Series;

namespace Rocket.WatchOrganizer.Core.ViewModels.WatchList
{
    public class WatchListViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly SerieService _service;

        public WatchListViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            if (_service == null)
            {
                _service = new SerieService();
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            await GetWatchListAsync();
        }

        #region Properties

        private List<Serie> _series;
        public List<Serie> Series
        {
            get => _series;
            set
            {
                _series = value;
                RaisePropertyChanged(() => Series);
            }
        }

        #endregion

        public IMvxAsyncCommand ShowAddSeriesCommand => new MvxAsyncCommand(async () => await ShowAddSeriesAsync());
        public IMvxAsyncCommand BackNavigation => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public async Task ShowAddSeriesAsync()
        {
            await _navigationService.Navigate<AddSerieViewModel>();
        }

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }

        public async Task GetWatchListAsync()
        {
            Series = await _service.GetSeriesAsync();
        }
    }
}
