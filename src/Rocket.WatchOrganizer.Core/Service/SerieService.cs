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
    public class SerieService
    {
        private SQLiteAsyncConnection _db;

        public SerieService()
        {
            if (_db != null)
                return;

            var database = Path.Combine(FileSystem.AppDataDirectory, "organizer.db");
            _db = new SQLiteAsyncConnection(database);
        }

        private async Task InitAsync()
        {
            await _db.CreateTableAsync<Serie>();
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

            return await _db.InsertAsync(Serie);
        }

        public async Task<List<Serie>> GetSeriesAsync()
        {
            await InitAsync();
            await AddSerieAsync();

            return await _db.Table<Serie>().ToListAsync();
        }
    }
}
