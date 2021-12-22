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
    public class ProizvodjaciController : BaseCrudController<Prodaja.Model.Proizvodjaci, ProizvodjaciSearchObject, ProizvodjaciInsertRequest, ProizvodjaciUpdateRequest>
    {
        public ProizvodjaciController(IRepositoryProizvodjaci _repositoryProizvodjaci) : base(_repositoryProizvodjaci)
        {
        }
    }
}
