using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Service;

namespace Rocket.WatchOrganizer.Core.ViewModels.WatchList
{
    public class WatchInfoPageViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly InfoService _service;

        public WatchInfoPageViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            if (_service == null)
            {
                _service = new InfoService();
            }
        }
        public override async Task Initialize()
        {
            await base.Initialize();
        }
        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }

    }
}
