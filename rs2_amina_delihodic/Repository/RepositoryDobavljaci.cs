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
    public class RepositoryDobavljaci : RepositoryBaseCrud<Prodaja.Model.Dobavljaci, Database.Dobavljaci , DobavljaciSearchObject, DobavljaciInsertRequest, DobavljaciUpdateRequest>, IRepositoryDobavljaci
    {
        public RepositoryDobavljaci(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IEnumerable<Prodaja.Model.Dobavljaci> Get(DobavljaciSearchObject search = null)
        {
            var entity = _context.Set<Database.Dobavljaci>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(search?.Adresa))
            {
                entity = entity.Where(x => x.Adresa.Contains(search.Adresa));
            }
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Dobavljaci>>(list);
        }
        public override Prodaja.Model.Dobavljaci Insert(DobavljaciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Dobavljaci>(request);
            _context.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Prodaja.Model.Dobavljaci>(entity);
        }
        public override Prodaja.Model.Dobavljaci Update(int id, DobavljaciUpdateRequest request)
        {
            var entity = _context.Dobavljaci.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Dobavljaci>(entity);
        }
    }
}
