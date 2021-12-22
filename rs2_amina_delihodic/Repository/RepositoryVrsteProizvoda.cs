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
    public class RepositoryVrsteProizvoda : RepositoryBaseCrud<Prodaja.Model.VrsteProizvoda, Database.VrsteProizvoda, object, VrsteProizvodaInsertRequest, VrsteProizvodaUpdateRequest>, IRepositoryVrsteProizvoda
    {
        public RepositoryVrsteProizvoda(MojDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
        
    }
}


   




