using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryProizvodi
    {
        List<Prodaja.Model.Proizvodi> Get(ProizvodiSearchObject request);
        Prodaja.Model.Proizvodi GetById(int id);

        Prodaja.Model.Proizvodi Insert(ProizvodiInsertRequest request);

        Prodaja.Model.Proizvodi Update(int id, ProizvodiInsertRequest request);
        
    }
}
