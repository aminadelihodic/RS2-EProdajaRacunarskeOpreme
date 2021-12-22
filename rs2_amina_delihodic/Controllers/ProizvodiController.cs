using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodiController : ControllerBase
    {
        private readonly IRepositoryProizvodi _service;
        public ProizvodiController(IRepositoryProizvodi service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Prodaja.Model.Proizvodi> Get([FromQuery] ProizvodiSearchObject request)
        {
            return _service.Get(request);
        }
        
        [HttpPost]
        public Prodaja.Model.Proizvodi Insert(ProizvodiInsertRequest request)
        {
            return _service.Insert(request);
        }

        
        [HttpPut("{id}")]
        public Prodaja.Model.Proizvodi Update(int id, [FromBody] ProizvodiInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Prodaja.Model.Proizvodi GetById(int id)
        {
            return _service.GetById(id);
        }
       
    }
}
