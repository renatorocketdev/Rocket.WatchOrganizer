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

        private List<Serie> _Series;
        public List<Serie> Series
        {
            get => _Series;
            set
            {
                _Series = value;
                RaisePropertyChanged(() => Series);
            }
        }

        #endregion

        public IMvxAsyncCommand ShowAddSeriesCommand => new MvxAsyncCommand(async () => await ShowAddSeriesAsync());

        public async Task ShowAddSeriesAsync()
        {
            await _navigationService.Navigate<AddSerieViewModel>();
        }

        public async Task GetWatchListAsync()
        {
            Series = await _service.GetSeriesAsync();
        }
    }
}