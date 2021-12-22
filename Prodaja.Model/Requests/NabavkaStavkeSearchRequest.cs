using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model.Requests
{
    public class NabavkaStavkeSearchRequest
    {
        public bool IncludeProizvodi { get; set; }
        public bool IncludeNabavka { get; set; }
    }
}
