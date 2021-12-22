using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class Korisnici
    {
        public Korisnici()
        {
            Narudzba = new HashSet<Narudzba>();
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Nabavka = new HashSet<Nabavka>();
        }

        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Nabavka> Nabavka { get; set; }
    }
}
