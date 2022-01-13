using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;

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

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public IMvxAsyncCommand ShowAddSeriesCommand => new MvxAsyncCommand(async () => await ShowAddSeriesAsync());

        public IMvxAsyncCommand ShowInfoPageCommand => new MvxAsyncCommand(async () => await ShowInfoPageAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }

        public async Task ShowAddSeriesAsync()
        {
            await _navigationService.Navigate<WatchedStep1ViewModel>();
        }

        public async Task ShowInfoPageAsync()
        {
            await _navigationService.Navigate<WatchInfoPageViewModel>();
        }

        public async Task GetWatchListAsync()
        {
            Series = await _service.GetSeriesAsync();
        }
    }
}
