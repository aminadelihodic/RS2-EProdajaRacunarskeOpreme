using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public partial class VrsteProizvoda
    {
        public int VrstaProizvodaId { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
