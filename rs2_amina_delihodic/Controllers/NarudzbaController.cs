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
    [Authorize]
    public class NarudzbaController : ControllerBase 
    {
        private readonly IRepositoryNarudzba _service;
        public NarudzbaController(IRepositoryNarudzba service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Prodavac")]
        public List<Prodaja.Model.Narudzba> Get([FromQuery] NarudzbaSearchObject request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public Prodaja.Model.Narudzba Insert(NarudzbaInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public Prodaja.Model.Narudzba Update(int id, [FromBody] NarudzbaUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Prodaja.Model.Narudzba GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
