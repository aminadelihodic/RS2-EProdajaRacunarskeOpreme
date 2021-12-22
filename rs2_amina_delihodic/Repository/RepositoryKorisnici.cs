using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.Filters;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using EProdajaRacunarskeOpreme.WebApi.Mapper;
using Microsoft.EntityFrameworkCore;
using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryKorisnici : IRepositoryKorisnici
    {
        private readonly MojDbContext _context;
        private readonly IMapper _mapper;

        public Prodaja.Model.Korisnici LogiraniKorisnik { get; set; }

        public RepositoryKorisnici(MojDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public List<Prodaja.Model.Korisnici> Get(KorisniciSearchObject request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            if (request?.IncludeKorisnickeUloge == true)
            {
                query = query.Include("KorisniciUloge.Uloga");
            }
            var list = query.ToList();

            return _mapper.Map<List<Prodaja.Model.Korisnici>>(list);
        }
        private static IQueryable<Database.Korisnici> IncludeUserDetails(IQueryable<Database.Korisnici> query)
        {
            return query
                .Include(x => x.KorisniciUloge).ThenInclude(x => x.Uloga)
                ;
        }
        public Prodaja.Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Prodaja.Model.Korisnici>(entity);
        }

        public Prodaja.Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<EProdajaRacunarskeOpreme.WebApi.Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new UserException("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                EProdajaRacunarskeOpreme.WebApi.Database.KorisniciUloge korisniciUloge = new EProdajaRacunarskeOpreme.WebApi.Database.KorisniciUloge
                {
                    KorisnikId = entity.KorisnikId,
                    UlogaId = uloga
                };
                _context.KorisniciUloge.Add(korisniciUloge);
            }
            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Korisnici>(entity);
        }

        public Prodaja.Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {

            var entity = _context.Korisnici.Find(id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Korisnici>(entity);
        }
        public async Task<Prodaja.Model.Korisnici> Login(string username, string password)
        {
            var entity = await _context.Korisnici.Include("KorisniciUloge.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogrešan username ili password");
            }

            return  _mapper.Map<Prodaja.Model.Korisnici>(entity);
        }
        public void SetLogiraniKorisnik(Prodaja.Model.Korisnici korisnik)
        {
            LogiraniKorisnik = korisnik;
        }
    }
}

