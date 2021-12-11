using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.ViewModels.AddMovies;

namespace Rocket.WatchOrganizer.Core.ViewModels.WatchList
{
    public class WatchListViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public WatchListViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand ShowAddMoviesCommand
        {
            get { return new MvxAsyncCommand(async () => await ShowAddMoviesAsync()); }
        }

        public async Task ShowAddMoviesAsync()
        {
            await _navigationService.Navigate<AddMoviesViewModel>();
        }
    }
}
