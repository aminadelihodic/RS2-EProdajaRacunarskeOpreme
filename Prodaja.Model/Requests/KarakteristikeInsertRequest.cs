using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model
{
    public class KarakteristikeInsertRequest
    {
        public bool Novo { get; set; }
        public string OperativniSistem { get; set; }
        public decimal VelicinaEkrana { get; set; }
        public decimal Ram { get; set; }
        public decimal Memorija { get; set; }
        public decimal Procesor { get; set; }
    }
}
