using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class Nabavka
    {
        public int NabavkaId { get; set; }
        public string BrojNabavke { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public int Kolicina { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }
        public Dobavljaci Dobavljac { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
