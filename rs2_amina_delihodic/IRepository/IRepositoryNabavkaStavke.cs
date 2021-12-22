using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryNabavkaStavke : IRepositoryCRUD<Prodaja.Model.NabavkaStavke, NabavkaStavkeSearchRequest, NabavkaStavkeInsertRequest, object>
    {
    }
}
