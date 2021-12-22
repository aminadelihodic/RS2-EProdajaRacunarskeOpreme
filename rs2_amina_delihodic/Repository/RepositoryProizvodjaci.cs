using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryProizvodjaci : RepositoryBaseCrud<Prodaja.Model.Proizvodjaci, Database.Proizvodjaci, ProizvodjaciSearchObject, ProizvodjaciInsertRequest, ProizvodjaciUpdateRequest>, IRepositoryProizvodjaci
    {
        public RepositoryProizvodjaci(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IEnumerable<Prodaja.Model.Proizvodjaci> Get(ProizvodjaciSearchObject search = null)
        {
            var entity = _context.Set<Database.Proizvodjaci>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Proizvodjaci>>(list);
        }


    }
}