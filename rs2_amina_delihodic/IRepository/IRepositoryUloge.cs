using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryUloge : IRepositoryCRUD<Prodaja.Model.Uloge, object, UlogeInsertRequest, UlogeUpdateRequest>
    {

    }
}
