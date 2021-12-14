using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Rocket.WatchOrganizer.Core.Models
{
    public class Episode
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Titulo { get; set; }

        [ForeignKey(typeof(Season))]
        public int IdSeason { get; set; }

        [ForeignKey(typeof(Watched))]
        public int IdWatched { get; set; }
    }
}
