using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sportski_klub.ViewModels
{
    public class ClanarinaViewModel
    {
        public int ID { get; set; }
        public int SportasID { get; set; }
        public int KlubID { get; set; }
        public DateTime Mjesec { get; set; }
        public double Iznos { get; set; }
    }
}