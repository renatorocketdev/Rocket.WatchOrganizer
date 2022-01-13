using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rocket.WatchOrganizer.Core.Models;

namespace Rocket.WatchOrganizer.Core.Service
{
    internal class EpisodeService : BaseService
    {
        public EpisodeService() : base()
        {

        }

        public async Task InitAsync()
        {
            await Db.CreateTableAsync<Season>();
        }

        public async Task<int> AddSeasonAsync()
        {
            await InitAsync();

            var Season = new Episode()
            {
                Titulo = "Episódio"
            };

            return await Db.InsertAsync(Season);
        }

        public async Task<List<Season>> GetSeasonAsync()
        {
            await InitAsync();
            await AddSeasonAsync();

            return await Db.Table<Season>().ToListAsync();
        }
    }
}
