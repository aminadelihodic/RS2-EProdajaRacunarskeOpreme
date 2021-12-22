using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryProizvodi : IRepositoryProizvodi
    {
        private readonly MojDbContext _context;
        private readonly IMapper _mapper;
        public RepositoryProizvodi(MojDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Prodaja.Model.Proizvodi> Get(ProizvodiSearchObject request)
        {
            var query = _context.Proizvodi.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }

            if (request?.IncludeVrstaProizvoda == true)
            {
                query = query.Include(x => x.VrstaProizvoda);
            }            
            if (request?.IncludeProizvodjac == true)
            {
                query = query.Include(x => x.Proizvodjac);
            }

            if (request?.VrstaProizvodaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaProizvodaId == request.VrstaProizvodaId);
            }


            var list = query.ToList();

            return _mapper.Map<List<Prodaja.Model.Proizvodi>>(list);
        }
    
        public Prodaja.Model.Proizvodi GetById(int id)
        {
            var entity = _context.Proizvodi.Find(id);

            return _mapper.Map<Prodaja.Model.Proizvodi>(entity);
        }
        public Prodaja.Model.Proizvodi Update(int id, ProizvodiInsertRequest request)
        {
            var entity = _context.Proizvodi.Find(id);
            _context.Proizvodi.Attach(entity);
            _context.Proizvodi.Update(entity);

            
            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Proizvodi>(entity);
        }

        public Prodaja.Model.Proizvodi Insert(ProizvodiInsertRequest request)
        {
            var entity = _mapper.Map<Database.Proizvodi>(request);

            

            _context.Proizvodi.Add(entity);
            _context.SaveChanges();

            
            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Proizvodi>(entity);
        }

       
    }
}
