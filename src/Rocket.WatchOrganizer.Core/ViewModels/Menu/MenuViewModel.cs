using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.ViewModels.Dashboard;
using Rocket.WatchOrganizer.Core.ViewModels.WatchList;
using Xamarin.Forms;

namespace Rocket.WatchOrganizer.Core.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand ShowDashboardCommand
        {
            get { return new MvxAsyncCommand(async () => await ShowDashboardAsync()); }
        }

        public async Task ShowDashboardAsync()
        {
            await _navigationService.Navigate<DashboardViewModel>();
            MenuControl();
        }

        public IMvxAsyncCommand ShowSeriesCommand
        {
            get { return new MvxAsyncCommand(async () => await ShowSeriesAsync()); }
        }

        public async Task ShowSeriesAsync()
        {
            await _navigationService.Navigate<WatchListViewModel>();
            MenuControl();
        }

        private void MenuControl()
        {
            if (Application.Current.MainPage is FlyoutPage masterDetailPage)
            {
                masterDetailPage.IsPresented = false;
            }
            else if (Application.Current.MainPage is NavigationPage navigationPage
                     && navigationPage.CurrentPage is FlyoutPage nestedMasterDetail)
            {
                nestedMasterDetail.IsPresented = false;
            }
        }
    }
}
