using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.IRepository
{
    public interface IRepositoryKlijenti : IRepositoryCRUD<Prodaja.Model.Klijenti, KlijentiSearchObject, KlijentiInsertRequest, KlijentiUpdateRequest>
    {
        public Task<Prodaja.Model.Klijenti> Login(string username, string password);
        void SetLogiraniKlijent(Klijenti klijenti);
    }
}
