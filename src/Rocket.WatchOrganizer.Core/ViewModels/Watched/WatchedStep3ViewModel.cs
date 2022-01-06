using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep3ViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public WatchedStep3ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }        
    }
}
