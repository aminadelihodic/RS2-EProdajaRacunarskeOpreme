using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class ProdaniProiz
    {
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }
        public decimal Ukupno { get; set; }
    }
}
