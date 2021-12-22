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
    public class RepositoryNarudzbaStavke : RepositoryBaseCrud<Prodaja.Model.NarudzbaStavke, Database.NarudzbaStavke, NarudzbaStavkeSearchRequest, NarudzbaStavkeInsertRequest, NarudzbaStavkeUpdateRequest>, IRepositoryNarudzbaStavke
    {
        public RepositoryNarudzbaStavke(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Prodaja.Model.NarudzbaStavke> Get(NarudzbaStavkeSearchRequest search = null)
        {
            var entity = _context.Set<Database.NarudzbaStavke>().AsQueryable();
            if(search?.NarudzbaId != null)
            {
                entity = entity.Where(x => x.NarudzbaId == search.NarudzbaId);
            }
            entity = entity.Include(x => x.Proizvod);
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.NarudzbaStavke>>(list);
        }

    }
}
