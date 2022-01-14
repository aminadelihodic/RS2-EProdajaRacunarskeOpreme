using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Microsoft.EntityFrameworkCore;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryNarudzba : RepositoryBaseCrud<Prodaja.Model.Narudzba, Database.Narudzba, NarudzbaSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>, IRepositoryNarudzba
    {
        public RepositoryNarudzba(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public override IEnumerable<Prodaja.Model.Narudzba> Get(NarudzbaSearchObject search = null)
        {
            var entity = _context.Set<Database.Narudzba>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
            {
                entity = entity.Where(x => x.BrojNarudzbe.Contains(search.BrojNarudzbe));
            }
            if (search?.IncludeKlijenti == true)
            {
                entity = entity.Include(x => x.Klijent);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Narudzba>>(list);
        }
        public override Prodaja.Model.Narudzba GetById(int id)
        {
            var entity = _context.Narudzba.Find(id);

            return _mapper.Map<Prodaja.Model.Narudzba>(entity);
        }
        public override Prodaja.Model.Narudzba Insert(NarudzbaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Narudzba>(request);
            _context.Add(entity);

            foreach (var item in request.stavke)
            {

                Database.NarudzbaStavke stavka = new Database.NarudzbaStavke
                {
                    Popust = item.Popust,
                    Kolicina = item.Kolicina,
                    Cijena = item.Cijena,
                    ProizvodId = item.ProizvodId
                };

                entity.NarudzbaStavke.Add(stavka);
            }


            _context.SaveChanges();
            return _mapper.Map<Prodaja.Model.Narudzba>(entity);
        }
        public override Prodaja.Model.Narudzba Update(int id, NarudzbaUpdateRequest request)
        {
            var entity = _context.Narudzba.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Narudzba>(entity);
        }

    }
    }
