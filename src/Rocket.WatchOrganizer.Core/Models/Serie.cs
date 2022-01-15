using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Rocket.WatchOrganizer.Core.Models
{
    public class Serie
    {
        public Serie()
        {
            IdProprio = Guid.NewGuid();
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public Guid IdProprio { get; set; }

        public string Titulo { get; set; }

        public string Banner { get; set; }

        public string Icone { get; set; }

        [OneToMany("IdSerie", "FK_Season_Serie")]
        public ObservableCollection<Season> Seasons { get; set; }

    }
}
