using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryNabavka : IRepositoryCRUD<Prodaja.Model.Nabavka, NabavkaSearchObject, NabavkaInsertRequest, NabavkaUpdateRequest>
    {
    }
}
