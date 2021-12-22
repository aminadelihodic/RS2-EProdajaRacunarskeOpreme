using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model.Requests
{
    public class OcjeneSearchRequest
    {
        public bool IncludeProizvodi { get; set; }
        public bool IncludeKlijent { get; set; }
    }
}
