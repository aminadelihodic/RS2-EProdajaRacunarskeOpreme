using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryKorisnici
    {
        List<Prodaja.Model.Korisnici> Get(KorisniciSearchObject request);
        Prodaja.Model.Korisnici GetById(int id);

        Prodaja.Model.Korisnici Insert(KorisniciInsertRequest request);

        Prodaja.Model.Korisnici Update(int id, KorisniciUpdateRequest request);
        
        public Task<Prodaja.Model.Korisnici> Login(string username, string password);
        void SetLogiraniKorisnik(Korisnici korisnici);
    }
}
