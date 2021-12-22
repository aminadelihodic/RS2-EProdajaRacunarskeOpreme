using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryBaseCrud<T,TDb, TSearch, TInsert, TUpdate> : RepositoryBase<T, TDb, TSearch>, IRepositoryCRUD<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TInsert : class where TUpdate : class where TDb:class
    {
        public RepositoryBaseCrud(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual T Insert(TInsert request)
        {
            var set = _context.Set<TDb>();
            var entity = _mapper.Map<TDb>(request);
            set.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDb>().Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }
    }

}
