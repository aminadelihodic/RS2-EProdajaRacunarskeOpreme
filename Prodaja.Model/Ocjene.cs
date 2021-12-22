using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }
        public int ProizvodId { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public Klijenti Klijent { get; set; }
        public Proizvodi Proizvodi { get; set; }
    }
}
