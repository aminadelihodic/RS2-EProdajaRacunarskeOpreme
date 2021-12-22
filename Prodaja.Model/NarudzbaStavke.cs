using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int ProizvodId { get; set; }

        public decimal UkupnaCijena => Cijena * Kolicina;

        //public Narudzba Narudzba { get; set; }
        public Proizvodi Proizvod { get; set; }
    }
}
