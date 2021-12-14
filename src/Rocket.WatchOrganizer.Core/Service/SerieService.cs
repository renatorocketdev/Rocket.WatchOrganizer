using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Rocket.WatchOrganizer.Core.Models;
using SQLite;
using Xamarin.Essentials;

namespace Rocket.WatchOrganizer.Core.Service
{
    public class SerieService : BaseService
    {
        public SerieService() : base()
        {

        }

        public async Task InitAsync()
        {
            await Db.CreateTableAsync<Serie>();
        }

        public async Task<int> AddSerieAsync()
        {
            await InitAsync();

            var Serie = new Serie()
            {
                Titulo = "Peaky Blinders",
                Banner = "https://studiosol-a.akamaihd.net/uploadfile/letras/playlists/3/1/1/c/311c0dc086b14fd29c2fa085771fe61e.jpg",
                Icone = "https://infinitasvidas.files.wordpress.com/2020/06/peaky-blinders.png?w=640"
            };

            return await Db.InsertAsync(Serie);
        }

        public async Task<List<Serie>> GetSeriesAsync()
        {
            await InitAsync();
            await AddSerieAsync();

            return await Db.Table<Serie>().ToListAsync();
        }
    }
}
