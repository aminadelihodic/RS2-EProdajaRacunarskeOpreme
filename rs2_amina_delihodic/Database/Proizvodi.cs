using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class Proizvodi
    {
        public Proizvodi()
        {
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            Ocjene = new HashSet<Ocjene>();
            NabavkaStavke = new HashSet<NabavkaStavke>();

        }

        [Key]
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Status { get; set; }
       
        public int ProizvodjacId { get; set; }
        public int VrstaProizvodaId { get; set; }




        public Proizvodjaci Proizvodjac { get; set; }
        public VrsteProizvoda VrstaProizvoda { get; set; }
        
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<NabavkaStavke> NabavkaStavke { get; set; }
    }
}
