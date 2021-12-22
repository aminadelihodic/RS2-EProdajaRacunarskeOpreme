using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class NarudzbaStavke
    {
        [Key]
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int ProizvodId { get; set; }

        public Narudzba Narudzba { get; set; }
        public Proizvodi Proizvod { get; set; }
    }
}
