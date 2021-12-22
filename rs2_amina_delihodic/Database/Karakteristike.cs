using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public class Karakteristike
    {
        public Karakteristike()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }
        [Key]
        public int KarakteristikeId { get; set; }
        public decimal Ram { get; set; }
        public decimal Memorija { get; set; }
        public decimal Procesor { get; set; }
        public decimal VelicinaEkrana { get; set; }
        public bool Novo { get; set; }
        public string OperativniSistem { get; set; }
        


        public ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
