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
    //[Route("api/[controller]")]
    //[ApiController]
    [Authorize]
    public class KarakteristikeController : BaseCrudController<Prodaja.Model.Karakteristike, object, KarakteristikeInsertRequest, KarakteristikeUpdateRequest>
    {
        public KarakteristikeController(IRepositoryKarakteristike _repositoryKarakteristike) : base(_repositoryKarakteristike)
        {
        }
    }
}
