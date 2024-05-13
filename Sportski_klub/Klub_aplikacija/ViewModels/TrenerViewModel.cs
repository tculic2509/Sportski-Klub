using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klub_aplikacija.ViewModels
{
    public class TrenerViewModel
    {
        public int ID { get; set; }
        public int KlubID { get; set; }
        public bool IsAdmin { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OIB { get; set; }
        public string Adresa { get; set; }
        public string Username { get; set; }
        public string Lozinka { get; set; }
    }
}