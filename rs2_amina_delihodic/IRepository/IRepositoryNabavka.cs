using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryNabavka 
    {
        List<Prodaja.Model.Nabavka> Get(NabavkaSearchObject request);
        Prodaja.Model.Nabavka GetById(int id);

        Prodaja.Model.Nabavka Insert(NabavkaInsertRequest request);

        Prodaja.Model.Nabavka Update(int id, NabavkaUpdateRequest request);
    }
}
