using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryBase<T, TDb,TSearch> : IReadRepository<T,TSearch> where T : class where TDb : class where TSearch:class
    {
        public MojDbContext _context { get; set; }
        protected readonly IMapper _mapper;
        public RepositoryBase(MojDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search=null)
        {
            var entity = _context.Set<TDb>();
            var list = entity.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = _context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}
