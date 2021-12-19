using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep2ViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public WatchedStep2ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand ShowNextStepCommand => new MvxAsyncCommand(async () => await ShowNextStepAsync());

        public async Task ShowNextStepAsync()
        {
            await _navigationService.Navigate<WatchedStep3ViewModel>();
        }
    }
}
