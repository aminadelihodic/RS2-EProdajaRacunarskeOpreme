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
    public class NabavkaController : ControllerBase 
    {
        private readonly IRepositoryNabavka _service;
        public NabavkaController(IRepositoryNabavka service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Prodavac")]
        public List<Prodaja.Model.Nabavka> Get([FromQuery] NabavkaSearchObject request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Prodavac")]
        public Prodaja.Model.Nabavka Insert(NabavkaInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public Prodaja.Model.Nabavka Update(int id, [FromBody] NabavkaUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Prodaja.Model.Nabavka GetById(int id)
        {
            return _service.GetById(id);
        }

    } 
}