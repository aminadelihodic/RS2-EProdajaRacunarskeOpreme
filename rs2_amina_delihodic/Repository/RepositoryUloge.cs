using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryUloge : RepositoryBaseCrud<Prodaja.Model.Uloge, Database.Uloge, object, UlogeInsertRequest, UlogeUpdateRequest>, IRepositoryUloge
    {
        public RepositoryUloge(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
