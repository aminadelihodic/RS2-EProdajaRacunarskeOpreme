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
    public class RepositoryNabavkaStavke : RepositoryBaseCrud<Prodaja.Model.NabavkaStavke, Database.NabavkaStavke, NabavkaStavkeSearchRequest, NabavkaStavkeInsertRequest, object>, IRepositoryNabavkaStavke
    {
        public RepositoryNabavkaStavke(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
        public override IEnumerable<Prodaja.Model.NabavkaStavke> Get(NabavkaStavkeSearchRequest search = null)
        {
            var entity = _context.Set<Database.NabavkaStavke>().AsQueryable();
            
            if (search?.IncludeProizvodi == true)
            {
                entity = entity.Include(x => x.Proizvodi);
            }
            if (search?.IncludeNabavka == true)
            {
                entity = entity.Include(x => x.Nabavka);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.NabavkaStavke>>(list);
        }
    }
}
