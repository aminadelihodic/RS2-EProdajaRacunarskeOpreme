using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.Filters;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
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
    public class RepositoryKlijenti : RepositoryBaseCrud<Prodaja.Model.Klijenti, Database.Klijenti, KlijentiSearchObject, KlijentiInsertRequest, KlijentiUpdateRequest>, IRepositoryKlijenti
    {
        public Prodaja.Model.Klijenti LogiraniKlijent { get; set; }

        public RepositoryKlijenti(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IEnumerable<Prodaja.Model.Klijenti> Get(KlijentiSearchObject search = null)
        {
            var entity = _context.Set<Database.Klijenti>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                entity = entity.Where(x => x.Ime.Contains(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                entity = entity.Where(x => x.Prezime.Contains(search.Prezime));
            }
            var list = entity.ToList();
            return _mapper.Map<List<Prodaja.Model.Klijenti>>(list);
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
        public override Prodaja.Model.Klijenti Insert(KlijentiInsertRequest request)
        {
            var entity = _mapper.Map<EProdajaRacunarskeOpreme.WebApi.Database.Klijenti>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new UserException("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);



            _context.Klijenti.Add(entity);
            _context.SaveChanges();


            _context.SaveChanges();

            return _mapper.Map<Prodaja.Model.Klijenti>(entity);

        }

        public async Task<Prodaja.Model.Klijenti> Login(string username, string password)
        {
            var entity = await _context.Klijenti.FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogrešan username ili password");
            }

            return _mapper.Map<Prodaja.Model.Klijenti>(entity);
        }


        public void SetLogiraniKlijent(Prodaja.Model.Klijenti klijent)
        {
            LogiraniKlijent = klijent;
        }
        public override Prodaja.Model.Klijenti Update(int id, KlijentiUpdateRequest request)
        {
            var entity = _context.Klijenti.Find(id);
            _context.Klijenti.Attach(entity);
            _context.Klijenti.Update(entity);

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

            return _mapper.Map<Prodaja.Model.Klijenti>(entity);
        }
    }
}


