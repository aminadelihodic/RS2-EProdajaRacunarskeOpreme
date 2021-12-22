using System;
using System.Collections.Generic;
using System.Text;

namespace Prodaja.Model.Requests
{
    public class NabavkaSearchObject
    {
        public string BrojNabavke { get; set; }
        public bool? IncludeKorisnik { get; set; }
        public bool? IncludeDobavljac { get; set; }
    }
}
