using System;
using System.Collections.Generic;
using System.Linq;

namespace Prodaja.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }

        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }

        public override string ToString()
        {
            return Ime;
        }

        public string Uloge
        {
            get
            {
                if (this.KorisniciUloge != null)
                {
                    return string.Join(", ", this.KorisniciUloge.Select(x => x.Uloga.Naziv));
                }

                return "";

            }
        }
    }
}