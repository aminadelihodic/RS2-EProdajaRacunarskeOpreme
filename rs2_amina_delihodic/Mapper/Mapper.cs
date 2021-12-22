using AutoMapper;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Prodaja.Model.Korisnici>()/*.ReverseMap()*/;
            CreateMap<KorisniciInsertRequest, Database.Korisnici>();
            CreateMap<KorisniciUpdateRequest, Database.Korisnici>();
            CreateMap<Database.VrsteProizvoda, Prodaja.Model.VrsteProizvoda>();
            CreateMap<VrsteProizvodaInsertRequest, Database.VrsteProizvoda>();
            CreateMap<VrsteProizvodaUpdateRequest, Database.VrsteProizvoda>();
            CreateMap<Database.Proizvodi, Prodaja.Model.Proizvodi>();
            CreateMap<ProizvodiInsertRequest,Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest,Database.Proizvodi>();
            CreateMap<Database.Dobavljaci, Prodaja.Model.Dobavljaci>();
            CreateMap<DobavljaciInsertRequest, Database.Dobavljaci>();
            CreateMap<DobavljaciUpdateRequest, Database.Dobavljaci>();
            CreateMap<Database.Karakteristike, Prodaja.Model.Karakteristike>();
            CreateMap<KarakteristikeInsertRequest, Database.Karakteristike>();
            CreateMap<KarakteristikeUpdateRequest, Database.Karakteristike>();
            CreateMap<Database.Klijenti, Prodaja.Model.Klijenti>();
            CreateMap<KlijentiInsertRequest, Database.Klijenti>();
            CreateMap<KlijentiUpdateRequest, Database.Klijenti>();
            CreateMap<Database.Nabavka, Prodaja.Model.Nabavka>();
            CreateMap<NabavkaInsertRequest, Database.Nabavka>();
            CreateMap<NabavkaUpdateRequest, Database.Nabavka>();
            CreateMap<Database.NabavkaStavke, Prodaja.Model.NabavkaStavke>();
            CreateMap<NabavkaStavkeInsertRequest, Database.NabavkaStavke>();
            CreateMap<Database.Ocjene, Prodaja.Model.Ocjene>();
            CreateMap<OcjeneInsertRequest, Database.Ocjene>();
            CreateMap<OcjeneUpdateRequest, Database.Ocjene>();
            CreateMap<Database.Proizvodjaci, Prodaja.Model.Proizvodjaci>();
            CreateMap<ProizvodjaciInsertRequest, Database.Proizvodjaci>();
            CreateMap<ProizvodjaciUpdateRequest, Database.Proizvodjaci>();
            CreateMap<Database.Uloge, Prodaja.Model.Uloge>();
            CreateMap<UlogeInsertRequest, Database.Uloge>();
            CreateMap<UlogeUpdateRequest, Database.Uloge>();
            CreateMap<Database.KorisniciUloge, Prodaja.Model.KorisniciUloge>();
            CreateMap<Database.Narudzba, Prodaja.Model.Narudzba>();
            CreateMap<NarudzbaInsertRequest, Database.Narudzba>();
            CreateMap<NarudzbaUpdateRequest, Database.Narudzba>();
            CreateMap<Database.NarudzbaStavke, Prodaja.Model.NarudzbaStavke>();
            CreateMap<NarudzbaStavkeInsertRequest, Database.NarudzbaStavke>();
            CreateMap<NarudzbaStavkeUpdateRequest, Database.NarudzbaStavke>();
        }
    }
}
