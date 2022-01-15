using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Rocket.WatchOrganizer.Core.Models
{
    public class Season
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public Guid IdProprio { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime DtAtualizacao { get; set; }

        [ForeignKey(typeof(Serie))]
        public int IdSerie { get; set; }

        [OneToMany("Idseason", "FK_Episode_Season")]
        public ObservableCollection<Episode> Episodes { get; set; }

        [Ignore]
        public string TituloSerie { get; set; }
    }
}
