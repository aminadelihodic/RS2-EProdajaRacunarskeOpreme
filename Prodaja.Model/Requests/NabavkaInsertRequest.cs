using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class NabavkaInsertRequest
    {
        public string BrojNabavke { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public int Kolicina { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }
    }
}
