using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryNarudzba : IRepositoryCRUD<Prodaja.Model.Narudzba, NarudzbaSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>
    {
        //List<Prodaja.Model.Narudzba> Get(NarudzbaSearchObject request);
        //Prodaja.Model.Narudzba GetById(int id);

        //Prodaja.Model.Narudzba Insert(NarudzbaInsertRequest request);

        //Prodaja.Model.Narudzba Update(int id, NarudzbaUpdateRequest request);
    }
}
