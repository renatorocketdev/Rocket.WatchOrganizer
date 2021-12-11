using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Service;
using Rocket.WatchOrganizer.Core.ViewModels.WatchList;

namespace Rocket.WatchOrganizer.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly SerieService _service;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            if (_service == null)
            {
                _service = new SerieService();
            }
        }

        public IMvxAsyncCommand ShowSeriesCommand => new MvxAsyncCommand(async () => await ShowSeriesAsync());

        public async Task ShowSeriesAsync()
        {
            await _navigationService.Navigate<WatchListViewModel>();
        }
    }
}
