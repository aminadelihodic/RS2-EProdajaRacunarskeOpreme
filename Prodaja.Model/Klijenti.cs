using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class Klijenti
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

    }
}
