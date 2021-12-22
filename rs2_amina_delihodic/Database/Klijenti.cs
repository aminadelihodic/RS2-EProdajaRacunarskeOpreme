using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class Klijenti
    {
        public Klijenti()
        {
            Narudzbe = new HashSet<Narudzba>();
            Ocjene = new HashSet<Ocjene>();
        }

        [Key]
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public ICollection<Narudzba> Narudzbe { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
    }
}
