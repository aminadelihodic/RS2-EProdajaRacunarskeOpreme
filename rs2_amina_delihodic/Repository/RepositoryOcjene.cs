using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Microsoft.EntityFrameworkCore;
using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryOcjene : RepositoryBaseCrud<Prodaja.Model.Ocjene, Database.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneUpdateRequest>, IRepositoryOcjene
    {
        public RepositoryOcjene(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IEnumerable<Prodaja.Model.Ocjene> Get(OcjeneSearchRequest search = null)
        {
            var entity = _context.Set<Database.Ocjene>().AsQueryable();

            if (search?.IncludeProizvodi == true)
            {
                entity = entity.Include(x => x.Proizvodi);
            }
            if (search?.IncludeKlijent == true)
            {
                entity = entity.Include(x => x.Klijent);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Ocjene>>(list);
        }
    }
}
