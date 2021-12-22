using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prodaja.Model;
namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryVrsteProizvoda : IRepositoryCRUD<Prodaja.Model.VrsteProizvoda, object, VrsteProizvodaInsertRequest, VrsteProizvodaUpdateRequest>
    {
    }
}
