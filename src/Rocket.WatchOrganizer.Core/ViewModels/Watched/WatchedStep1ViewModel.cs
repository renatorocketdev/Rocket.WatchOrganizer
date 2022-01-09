using System.Threading.Tasks;
using FluentValidation;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Validators;
using Rocket.WatchOrganizer.Core.ViewModels.Watched;
using Xamarin.Forms;

namespace Rocket.WatchOrganizer.Core.ViewModels.Watched
{
    public class WatchedStep1ViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly SerieValidator _validator;

        public WatchedStep1ViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            _validator = new SerieValidator();
        }

        public IMvxAsyncCommand ShowNextStepCommand => new MvxAsyncCommand(async () => await ShowNextStepAsync());

        public async Task ShowNextStepAsync()
        {
            await _navigationService.Navigate<WatchedStep2ViewModel>();
        }


        private Serie _series = new Serie();
        public Serie Series
        {
            get => _series;
            set
            {
                _series = value;
                RaisePropertyChanged(() => Series);
            }
        }

        public IMvxAsyncCommand ValidateSerieCommand => new MvxAsyncCommand(async () => await ValidateSerieAsync());

        public async Task ValidateSerieAsync()
        {
            string msg = "";
            var validationResult = _validator.Validate(Series);
            if (validationResult.IsValid)
            {
                msg = "Validation Success..!!";
            }
            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    msg += $",{failure.ErrorMessage}";
                }
            }

            await Application.Current.MainPage.DisplayAlert("YourApp", msg, "Ok");
        }
    }
}
