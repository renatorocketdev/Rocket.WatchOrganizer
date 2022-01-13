using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep1ViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public WatchedStep1ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public IMvxAsyncCommand ShowNextStepCommand => new MvxAsyncCommand(async () => await ShowNextStepAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }
        public async Task ShowNextStepAsync()
        {
            await _navigationService.Navigate<WatchedStep2ViewModel>();
        }
    }
}
