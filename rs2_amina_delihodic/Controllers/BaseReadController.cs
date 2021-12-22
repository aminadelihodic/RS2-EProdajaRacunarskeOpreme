using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BaseReadController<T,TSearch> : ControllerBase where T : class where TSearch:class
    {
        private readonly IReadRepository<T,TSearch> _repositoryRead;
        public BaseReadController(IReadRepository<T,TSearch> repositoryRead)
        {
            _repositoryRead = repositoryRead;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery]TSearch search=default)
        {
            return _repositoryRead.Get(search);
        }
        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _repositoryRead.GetById(id);
        }
    }
}
