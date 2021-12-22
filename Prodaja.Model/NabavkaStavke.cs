using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class NabavkaStavke
    {
        public int NabavkaStavkeId { get; set; }
        public int NabavkaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public Proizvodi Proizvodi { get; set; }
        public Nabavka Nabavka { get; set; }

        public decimal UkupnaCijena => Cijena * Kolicina;
    }
}
