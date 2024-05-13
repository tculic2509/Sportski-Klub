using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sportski_klub.ViewModels
{
    public class KlubViewModel
    {
        public int ID { get; set; }
        public string ImeKluba { get; set; }
        public System.DateTime DatumOsnivanja { get; set; }
        public int OIB { get; set; }
        public double Clanarina { get; set; }
        public string Adresa { get; set; }
    }
}