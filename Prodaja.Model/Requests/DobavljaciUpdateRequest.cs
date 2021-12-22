using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class DobavljaciUpdateRequest
    {
        public string Naziv { get; set; }
        public string KontaktOsoba { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Napomena { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
    }
}
