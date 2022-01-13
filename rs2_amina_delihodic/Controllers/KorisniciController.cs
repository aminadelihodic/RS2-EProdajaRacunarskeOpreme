using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prodaja.Model;
using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KorisniciController : ControllerBase
    {
        private readonly IRepositoryKorisnici _service;
        public KorisniciController(IRepositoryKorisnici service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Prodavac")]
        public List<Prodaja.Model.Korisnici> Get([FromQuery] KorisniciSearchObject request)
        {
            return _service.Get(request);
        }
        
        [HttpPost]
        public Prodaja.Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        
        [HttpPut("{id}")]
        public Prodaja.Model.Korisnici Update(int id, [FromBody] KorisniciUpdateRequest request)
        {
            return _service.Update(id, request);
        }
        
        [HttpGet("{id}")]
        public Prodaja.Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
