using EProdajaRacunarskeOpreme.WebApi.IRepository;
using EProdajaRacunarskeOpreme.WebApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class RecommendationsController : ControllerBase
    {
        private readonly IRepositoryRecommended _repository;
        public RecommendationsController(IRepositoryRecommended repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult RecommendedProduct(int proizvodid)
        {
            try
            {
                return Ok(_repository.RecommendedProduct(proizvodid));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
