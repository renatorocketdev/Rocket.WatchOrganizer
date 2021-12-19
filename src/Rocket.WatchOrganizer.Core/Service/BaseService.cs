using System.IO;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Essentials;

namespace Rocket.WatchOrganizer.Core.Service
{
    public abstract class BaseService
    {
        public SQLiteAsyncConnection Db;

        public BaseService()
        {
            if (Db != null)
                return;

            var database = Path.Combine(FileSystem.AppDataDirectory, "organizer.db");
            Db = new SQLiteAsyncConnection(database);
        }
    }
}
