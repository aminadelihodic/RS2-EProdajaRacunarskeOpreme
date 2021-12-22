using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class Proizvodi
    {
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


        public override string ToString()
        {
            return Naziv;
        }







    }
}
