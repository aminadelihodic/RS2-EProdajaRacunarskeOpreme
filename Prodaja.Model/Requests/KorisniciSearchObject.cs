using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class KorisniciSearchObject
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool IncludeKorisnickeUloge { get; set; }
    }
}
