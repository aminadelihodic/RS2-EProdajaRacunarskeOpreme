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
    public class UlogeController : BaseCrudController<Prodaja.Model.Uloge, object, UlogeInsertRequest, UlogeUpdateRequest>
    {
        public UlogeController(IRepositoryUloge _repositoryUloge) : base(_repositoryUloge)
        {
        }
    }
}
