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
    public class RepositoryNabavka : IRepositoryNabavka 
    {
        private readonly MojDbContext _context;
        private readonly IMapper _mapper;
        public RepositoryNabavka(MojDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Prodaja.Model.Nabavka> Get(NabavkaSearchObject request)
        {
            var entity = _context.Set<Database.Nabavka>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.BrojNabavke))
            {
                entity = entity.Where(x => x.BrojNabavke.Contains(request.BrojNabavke));
            }
            if (request?.IncludeDobavljac == true)
            {
                entity = entity.Include(x => x.Dobavljac);
            }
            if (request?.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Nabavka>>(list);
        }

        public Prodaja.Model.Nabavka GetById(int id)
        {
            var entity = _context.Nabavka.Find(id);

            return _mapper.Map<Prodaja.Model.Nabavka>(entity);
        }

        public Prodaja.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Nabavka>(request);
            _context.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Prodaja.Model.Nabavka>(entity);
        }

        public Prodaja.Model.Nabavka Update(int id, NabavkaUpdateRequest request)
        {
            var entity = _context.Nabavka.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Nabavka>(entity);
        }
        }
    }
