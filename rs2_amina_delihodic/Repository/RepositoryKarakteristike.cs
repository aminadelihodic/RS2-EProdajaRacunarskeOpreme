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
    public class RepositoryKarakteristike : RepositoryBaseCrud<Prodaja.Model.Karakteristike, Database.Karakteristike, object, KarakteristikeInsertRequest, KarakteristikeUpdateRequest>, IRepositoryKarakteristike
    {
        public RepositoryKarakteristike(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
