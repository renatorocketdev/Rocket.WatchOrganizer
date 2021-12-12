using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using Rocket.WatchOrganizer.Core.Models;
using Rocket.WatchOrganizer.Core.Service;
using Rocket.WatchOrganizer.Core.ViewModels.WatchList;

namespace Rocket.WatchOrganizer.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly SerieService _service;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            if (_service == null)
            {
                _service = new SerieService();
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            GetWatchListAsync();
        }

        private void GetWatchListAsync()
        {
            Series = new List<Serie>
            {
                new Serie
                {
                    Banner = "https://studiosol-a.akamaihd.net/uploadfile/letras/playlists/3/1/1/c/311c0dc086b14fd29c2fa085771fe61e.jpg",
                },
                new Serie
                {
                    Banner = "https://manualdosgames.com/wp-content/uploads/2020/10/The-Witcher.png",
                },
                new Serie
                {
                    Banner = "https://presleyson.com.br/wp-content/uploads/2019/02/mr-robot-1200x630-min.jpg"
                }
            };

            Animes = new List<Serie>
            {
                new Serie
                {
                    Banner = "https://criticalhits.com.br/wp-content/uploads/2021/11/Luffy_and_His_Crew.png",
                },
                new Serie
                {
                    Banner = "https://cdn.pensador.com/img/authors/na/ru/naruto-l.jpg",
                },
                new Serie
                {
                    Banner = "https://www.einerd.com.br/wp-content/uploads/2018/09/bleach-sa%C3%BAde-tite-kubo-capa.jpg"
                }
            };
        }


        #region Properties

        private List<Serie> _series;
        public List<Serie> Series
        {
            get => _series;
            set
            {
                _series = value;
                RaisePropertyChanged(() => Series);
            }
        }

        private List<Serie> _animes;
        public List<Serie> Animes
        {
            get => _animes;
            set
            {
                _animes = value;
                RaisePropertyChanged(() => Animes);
            }
        }

        #endregion

        public IMvxAsyncCommand ShowSeriesCommand => new MvxAsyncCommand(async () => await ShowSeriesAsync());

        public async Task ShowSeriesAsync()
        {
            await _navigationService.Navigate<WatchListViewModel>();
        }
    }
}
