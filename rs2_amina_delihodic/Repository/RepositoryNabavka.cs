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
    public class RepositoryNabavka : RepositoryBaseCrud<Prodaja.Model.Nabavka, Database.Nabavka, NabavkaSearchObject, NabavkaInsertRequest, NabavkaUpdateRequest>, IRepositoryNabavka
    {
        public RepositoryNabavka(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IEnumerable<Prodaja.Model.Nabavka> Get(NabavkaSearchObject search = null)
        {
            var entity = _context.Set<Database.Nabavka>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.BrojNabavke))
            {
                entity = entity.Where(x => x.BrojNabavke.Contains(search.BrojNabavke));
            }
            if (search?.IncludeDobavljac == true)
            {
                entity = entity.Include(x => x.Dobavljac);
            }
            if (search?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Nabavka>>(list);
        }
        public override Prodaja.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Nabavka>(request);
            _context.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Prodaja.Model.Nabavka>(entity);
        }
        public override Prodaja.Model.Nabavka Update(int id, NabavkaUpdateRequest request)
        {
            var entity = _context.Nabavka.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Nabavka>(entity);
        }
        
    }
}
