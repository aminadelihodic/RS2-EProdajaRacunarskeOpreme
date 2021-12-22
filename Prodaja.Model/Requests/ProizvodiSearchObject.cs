using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class ProizvodiSearchObject
    {
        public string Naziv { get; set; }
        
        public int? VrstaProizvodaId { get; set; }

        public bool? IncludeVrstaProizvoda { get; set; }
        public bool? IncludeProizvodjac { get; set; }
    }
}
