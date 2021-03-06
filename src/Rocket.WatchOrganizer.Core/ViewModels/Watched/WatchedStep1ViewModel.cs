using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep1ViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public WatchedStep1ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand ShowNextStepCommand => new MvxAsyncCommand(async () => await ShowNextStepAsync());

        public async Task ShowNextStepAsync()
        {
            await _navigationService.Navigate<WatchedStep2ViewModel>();
        }
    }
}
