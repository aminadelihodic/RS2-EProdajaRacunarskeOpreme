using EProdajaRacunarskeOpreme.WebApi.IRepository;
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
    public class BaseCrudController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly IRepositoryCRUD<T, TSearch, TInsert, TUpdate> _repositoryCrud;
        public BaseCrudController(IRepositoryCRUD<T, TSearch, TInsert, TUpdate> repositoryCrud) : base(repositoryCrud)
        {
            _repositoryCrud = repositoryCrud;
        }
        [HttpPost]
        public T Insert([FromBody] TInsert request)
        {
            return _repositoryCrud.Insert(request);
        }
        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate request)
        {
            return _repositoryCrud.Update(id,request);
        }
    }
}
