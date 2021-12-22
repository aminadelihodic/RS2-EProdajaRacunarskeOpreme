using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class Proizvodjaci
    {
        public Proizvodjaci()
        {
            Proizvodi = new HashSet<Proizvodi>();

        }
        [Key]
        public int ProizvodjacId { get; set; }
        public string Naziv { get; set; }


        public ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
