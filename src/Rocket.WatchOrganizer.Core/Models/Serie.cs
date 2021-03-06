using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Rocket.WatchOrganizer.Core.Models
{
    public class Serie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Banner { get; set; }

        public string Icone { get; set; }

        [OneToMany("IdSerie", "FK_Season_Serie")]
        public List<Season> Seasons { get; set; }
    }
}
