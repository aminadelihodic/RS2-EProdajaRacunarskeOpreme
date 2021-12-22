using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class NabavkaStavke
    {
        [Key]
        public int NabavkaStavkeId { get; set; }
        public int NabavkaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public Proizvodi Proizvodi { get; set; }
        public Nabavka Nabavka { get; set; }
    }
}
