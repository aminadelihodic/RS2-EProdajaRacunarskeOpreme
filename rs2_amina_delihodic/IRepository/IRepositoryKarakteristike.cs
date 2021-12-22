using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryKarakteristike:IRepositoryCRUD<Prodaja.Model.Karakteristike, object, KarakteristikeInsertRequest, KarakteristikeUpdateRequest>
    {
    }
}
