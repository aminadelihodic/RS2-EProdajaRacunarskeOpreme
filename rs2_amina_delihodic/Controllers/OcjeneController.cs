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
    //[Route("api/[controller]")]
    //[ApiController]
    [Authorize]
    public class OcjeneController : BaseCrudController<Prodaja.Model.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneUpdateRequest>
    {
        public OcjeneController(IRepositoryOcjene _repositoryOcjene) : base(_repositoryOcjene)
        {
        }
    }
}
