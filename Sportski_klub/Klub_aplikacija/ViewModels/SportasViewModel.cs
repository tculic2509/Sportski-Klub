using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klub_aplikacija.ViewModels
{
    public class SportasViewModel
    {
        public int ID { get; set; }
        public int KlubID { get; set; }
        public Nullable<int> TrenerID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumRodenja { get; set; }
        public int OIB { get; set; }
        public string MjestoStanovanja { get; set; }
        public string Adresa { get; set; }
        public Nullable<System.DateTime> LijecnickiPregledVrijediDo { get; set; }
        public System.DateTime DatumUpisa { get; set; }
    }
}