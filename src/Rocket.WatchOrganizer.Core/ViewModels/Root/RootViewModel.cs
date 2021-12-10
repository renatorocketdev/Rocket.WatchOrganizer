using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.ViewModels.Home;
using Rocket.WatchOrganizer.Core.ViewModels.Menu;

namespace Rocket.WatchOrganizer.Core.ViewModels.Root
{
    public class RootViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public RootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        public override async void ViewAppearing()
        {
            base.ViewAppearing();

            await _navigationService.Navigate<MenuViewModel>();
            await _navigationService.Navigate<HomeViewModel>();
        }
    }
}
