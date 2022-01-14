using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Newtonsoft.Json;
using Rocket.WatchOrganizer.Core.Models;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep1ViewModel : BaseViewModel
    {
        #region Properties

        private Serie _serie;
        public Serie Serie
        {
            get => _serie;
            set
            {
                _serie = value;
                RaisePropertyChanged(() => Serie);
            }
        }

        #endregion

        private readonly IMvxNavigationService _navigationService;

        public WatchedStep1ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Prepare()
        {
            base.Prepare();

            Serie = new Serie();
        }

        public IMvxAsyncCommand BackNavigationCommand => new MvxAsyncCommand(async () => await BackNavigationAsync());
        public IMvxAsyncCommand ShowNextStepCommand => new MvxAsyncCommand(async () => await ShowNextStepAsync());

        public async Task BackNavigationAsync()
        {
            await _navigationService.Close(this);
        }

        public async Task ShowNextStepAsync()
        {
            await _navigationService.Navigate<WatchedStep2ViewModel, Serie>(_serie);
        }
    }
}
