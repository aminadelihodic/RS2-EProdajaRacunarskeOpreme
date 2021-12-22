using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EProdajaRacunarskeOpreme.WebApi.IRepository;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryCRUD<T,TSearch,TInsert,TUpdate> :IReadRepository<T,TSearch> where T:class where TSearch:class where TInsert:class where TUpdate:class
    {
        T Insert(TInsert request);
        T Update(int id,TUpdate request);
    }
}
