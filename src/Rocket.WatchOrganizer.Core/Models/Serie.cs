using SQLite;

namespace Rocket.WatchOrganizer.Core.Models
{
    public class Serie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Banner { get; set; }
        public string Icone { get; set; }
    }
}
