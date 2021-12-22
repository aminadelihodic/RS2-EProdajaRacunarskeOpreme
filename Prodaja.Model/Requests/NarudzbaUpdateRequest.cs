using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class NarudzbaUpdateRequest
    {
        
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosRacuna { get; set; }
        public int KlijentId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
    }
}
