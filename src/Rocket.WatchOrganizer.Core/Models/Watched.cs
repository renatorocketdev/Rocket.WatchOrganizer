using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Rocket.WatchOrganizer.Core.Models
{
    public class Watched
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime DtAssistido { get; set; }

        [OneToMany("IdWatched", "FK_Episodes_Watch")]
        public List<Episode> Episodes { get; set; }
    }
}
