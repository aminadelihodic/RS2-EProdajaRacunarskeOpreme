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
    public class NabavkaStavkeController : BaseCrudController<Prodaja.Model.NabavkaStavke, NabavkaStavkeSearchRequest, NabavkaStavkeInsertRequest, object>
    {
        public NabavkaStavkeController(IRepositoryNabavkaStavke _repositoryNabavkaStavke) : base(_repositoryNabavkaStavke)
        {
        }
    }
}