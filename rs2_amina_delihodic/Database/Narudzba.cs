using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class Narudzba
    {
        public Narudzba()
        {

            NarudzbaStavke = new HashSet<NarudzbaStavke>();

        }

        [Key]
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosRacuna { get; set; }
        public Klijenti Klijent { get; set; }


        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
