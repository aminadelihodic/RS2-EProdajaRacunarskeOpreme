using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryRecommended
    {
        List<Prodaja.Model.Proizvodi> RecommendedProduct(int proizvodid);
    }
}
