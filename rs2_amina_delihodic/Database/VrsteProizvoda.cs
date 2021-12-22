using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class VrsteProizvoda
    {
        public VrsteProizvoda()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }
        [Key]
        public int VrstaProizvodaId { get; set; }
        public string Naziv { get; set; }


        public ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
