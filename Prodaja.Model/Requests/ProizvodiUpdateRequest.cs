using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class ProizvodiUpdateRequest
    {
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public bool? Status { get; set; }
        public int ProizvodjacId { get; set; }
        public int VrstaProizvodaId { get; set; }




       
    }
}
