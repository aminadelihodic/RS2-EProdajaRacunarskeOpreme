using EProdajaRacunarskeOpreme.WebApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public partial class MojDbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(RepositoryKorisnici.GenerateSalt());
            }

            for (int i = 0; i < 5; i++)
            {
                Salt.Add(RepositoryKlijenti.GenerateSalt());
            }

            #region Dodavanje korisnickih uloga
            modelBuilder.Entity<Uloge>().HasData(
                new Uloge()
                {
                    UlogaId = 1,
                    Naziv = "Admin",
                    Opis = "Upravljanje sistemom"
                });
            #endregion

            #region Dodavanje proizvoda
            modelBuilder.Entity<Proizvodi>().HasData(
                new Proizvodi()
                {
                    ProizvodId = 1,
                    Naziv = "Evoluent Vertical Mouse",
                    Sifra = "12345",
                    Cijena = 220,
                    Slika = File.ReadAllBytes("Images/R (1).jpg"),
                    SlikaThumb = File.ReadAllBytes("Images/R (1).jpg"),
                    Status = true,
                    ProizvodjacId = 1,
                    VrstaProizvodaId = 2
                },
                new Proizvodi()
                {
                    ProizvodId = 2,
                    Naziv = "USB optički miš Logitech",
                    Sifra = "B100",
                    Cijena = 16,
                    Slika = File.ReadAllBytes("Images/R (1).jpg"),
                    SlikaThumb = File.ReadAllBytes("Images/R (1).jpg"),
                    Status = true,
                    ProizvodjacId = 1,
                    VrstaProizvodaId = 2
                },
                new Proizvodi()
                {
                    ProizvodId = 3,
                    Naziv = "HP ENVY x360 ",
                    Sifra = "13-ay0477ng",
                    Cijena = 3700,
                    Slika = File.ReadAllBytes("Images/R.jpg"),
                    SlikaThumb = File.ReadAllBytes("Images/R.jpg"),
                    Status = true,
                    ProizvodjacId = 1,
                    VrstaProizvodaId = 1
                },
            new Proizvodi()
            {
                ProizvodId = 4,
                Naziv = "Microsoft 31.5 cm ",
                Sifra = "989485",
                Cijena = 3850,
                Slika = File.ReadAllBytes("Images/R.jpg"),
                SlikaThumb = File.ReadAllBytes("Images/R.jpg"),
                Status = false,
                ProizvodjacId = 1,
                VrstaProizvodaId = 1
            },
            new Proizvodi()
            {
                ProizvodId = 5,
                Naziv = "Odys 35.8 cm",
                Sifra = "5787",
                Cijena = 1250,
                Slika = File.ReadAllBytes("Images/R.jpg"),
                SlikaThumb = File.ReadAllBytes("Images/R.jpg"),
                Status = true,
                ProizvodjacId = 1,
                VrstaProizvodaId = 1
            },
             new Proizvodi()
             {
                 ProizvodId = 6,
                 Naziv = "MX Vertikalna bežična tastatura",
                 Sifra = "8787",
                 Cijena = 645,
                 Slika = File.ReadAllBytes("Images/w (2).jpg"),
                 SlikaThumb = File.ReadAllBytes("Images/w (2).jpg"),
                 Status = true,
                 ProizvodjacId = 1,
                 VrstaProizvodaId = 3
             },
             new Proizvodi()
             {
                 ProizvodId = 7,
                 Naziv = "MX Master for Business USB",
                 Sifra = "787",
                 Cijena = 755,
                 Slika = File.ReadAllBytes("Images/w (2).jpg"),
                 SlikaThumb = File.ReadAllBytes("Images/w (2).jpg"),
                 Status = true,
                 ProizvodjacId = 1,
                 VrstaProizvodaId = 3
             },
             new Proizvodi()
             {
                 ProizvodId = 8,
                 Naziv = "Slušalice s mikrofonom PC 7",
                 Sifra = "657",
                 Cijena = 65,
                 Slika = File.ReadAllBytes("Images/w (4).jpg"),
                 SlikaThumb = File.ReadAllBytes("Images/w (4).jpg"),
                 Status = true,
                 ProizvodjacId = 1,
                 VrstaProizvodaId = 4
             },
             new Proizvodi()
             {
                 ProizvodId = 9,
                 Naziv = "Bežične DECT Jabra GN9120 Mono Midi Boom",
                 Sifra = "98",
                 Cijena = 88,
                 Slika = File.ReadAllBytes("Images/w (4).jpg"),
                 SlikaThumb = File.ReadAllBytes("Images/w (4).jpg"),
                 Status = true,
                 ProizvodjacId = 2,
                 VrstaProizvodaId = 4
             },
             new Proizvodi()
             {
                 ProizvodId = 10,
                 Naziv = "HP125",
                 Sifra = "98",
                 Cijena = 1500,
                 Slika = File.ReadAllBytes("Images/R.jpg"),
                 SlikaThumb = File.ReadAllBytes("Images/R.jpg"),
                 Status = true,
                 ProizvodjacId = 3,
                 VrstaProizvodaId = 1
             });
            #endregion

            #region Dodavanje dobavljaca
            modelBuilder.Entity<Dobavljaci>().HasData(
                new Dobavljaci()
                {
                    DobavljacId = 1,
                    Naziv = "Amir",
                    KontaktOsoba = "Amir",
                    Adresa = "Muje Pasica 7",
                    Telefon = "95898659",
                    Fax = "030234342",
                    Web = "www.amir.com",
                    Email = "amir@mail.com",
                    ZiroRacuni = "9090909",
                    Napomena = "Napomena 1",
                    Status = true,
                    Slika = File.ReadAllBytes("Images/OIP.jpg")
                },
                new Dobavljaci()
                {
                    DobavljacId = 2,
                    Naziv = "Test1",
                    KontaktOsoba = "Test1",
                    Adresa = "Adresa Test1",
                    Telefon = "3984039049",
                    Fax = "0029039",
                    Web = "www.test1.com",
                    Email = "test1@mail.com",
                    ZiroRacuni = "59849854",
                    Napomena = "Napomena 2",
                    Status = true,
                    Slika = File.ReadAllBytes("Images/OIP.jpg")
                },
                new Dobavljaci()
                {
                    DobavljacId = 3,
                    Naziv = "Dobavljac 3",
                    KontaktOsoba = "Đenana",
                    Adresa = "Adresa 3",
                    Telefon = "45848958",
                    Fax = "4354545",
                    Web = "www.denana.com",
                    Email = "denana@mail.com",
                    ZiroRacuni = "69586985",
                    Napomena = "Napomena 3",
                    Status = false,
                    Slika = File.ReadAllBytes("Images/OIP.jpg")
                });
            #endregion

            #region Dodavanje karakteristika
            modelBuilder.Entity<Karakteristike>().HasData(
                new Karakteristike()
                {
                    KarakteristikeId = 1,
                    Novo = true,
                    OperativniSistem = "Android",
                    Ram = 8,
                    Memorija = 256,
                    Procesor = 3,
                    VelicinaEkrana = 19
                },
                new Karakteristike()
                {
                    KarakteristikeId = 2,
                    Novo = true,
                    OperativniSistem = "Android",
                    VelicinaEkrana = 35,
                    Ram = 6,
                    Memorija = 128,
                    Procesor = 2
                },
                new Karakteristike()
                {
                    KarakteristikeId = 3,
                    Novo = false,
                    OperativniSistem = "IOS",
                    VelicinaEkrana = 12,
                    Ram = 4,
                    Memorija = 128,
                    Procesor = 2
                },
                new Karakteristike()
                {
                    KarakteristikeId = 4,
                    Novo = true,
                    OperativniSistem = "Android",
                    VelicinaEkrana = 20,
                    Ram = 4,
                    Memorija = 128,
                    Procesor = 2
                });
            #endregion

            #region Dodavanje klijenata
            modelBuilder.Entity<Klijenti>().HasData(
                new Klijenti()
                {
                    KlijentId = 1,
                    Ime = "Amir",
                    Prezime = "Amir",
                    DatumRegistracije = DateTime.Now,
                    Email = "amir@mail.com",
                    Telefon = "063232213",
                    KorisnickoIme = "amir",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = RepositoryKlijenti.GenerateHash(Salt[0], "test")
                },
                new Klijenti()
                {
                    KlijentId = 2,
                    Ime = "User",
                    Prezime = "User",
                    DatumRegistracije = DateTime.Now,
                    Email = "user@mail.com",
                    Telefon = "063132233",
                    KorisnickoIme = "user",
                    LozinkaSalt = Salt[1],
                    LozinkaHash = RepositoryKlijenti.GenerateHash(Salt[1], "test")
                },
                new Klijenti()
                {
                    KlijentId = 3,
                    Ime = "Amina",
                    Prezime = "Đelihođić",
                    DatumRegistracije = DateTime.Now,
                    Email = "amina@mail.com",
                    Telefon = "063020202",
                    KorisnickoIme = "amina",
                    LozinkaSalt = Salt[2],
                    LozinkaHash = RepositoryKlijenti.GenerateHash(Salt[2], "test")
                });
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnici>().HasData(
                new Korisnici()
                {
                    KorisnikId = 1,
                    Ime = "Admin",
                    Prezime = "Admin",
                    Email = "admin@mail.com",
                    Telefon = "063232983",
                    KorisnickoIme = "admin",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = RepositoryKorisnici.GenerateHash(Salt[0], "test")
                });
            #endregion

            #region Dodavanje korisnickih uloga korisnicima
            modelBuilder.Entity<KorisniciUloge>().HasData(
                new KorisniciUloge()
                {
                    KorisnikUlogaId = 1,
                    KorisnikId = 1,
                    UlogaId = 1,
                    DatumIzmjene = DateTime.Now
                }
            );
            #endregion

            #region Dodavanje vrsta proizvoda
            modelBuilder.Entity<VrsteProizvoda>().HasData(
                new VrsteProizvoda()
                {
                    VrstaProizvodaId = 1,
                    Naziv = "Laptop",
                },
                new VrsteProizvoda()
                {
                    VrstaProizvodaId = 2,
                    Naziv = "Miš",
                },
                new VrsteProizvoda()
                {
                    VrstaProizvodaId = 3,
                    Naziv = "Tastatura",
                },
                new VrsteProizvoda()
                {
                    VrstaProizvodaId = 4,
                    Naziv = "Slusalice",
                }
            );
            #endregion

            #region Dodavanje nabavki
            modelBuilder.Entity<Nabavka>().HasData(
                new Nabavka()
                {
                    NabavkaId = 1,
                    BrojNabavke = "1",
                    Datum = DateTime.Now,
                    IznosRacuna = 1500,
                    KorisnikId = 1,
                    DobavljacId = 1,
                    Kolicina = 2
                },
                new Nabavka()
                {
                    NabavkaId = 2,
                    BrojNabavke = "2",
                    Datum = DateTime.Now,
                    IznosRacuna = 1000,
                    Kolicina = 3,
                    KorisnikId = 1,
                    DobavljacId = 2
                },
                new Nabavka()
                {
                    NabavkaId = 3,
                    BrojNabavke = "3",
                    Datum = DateTime.Now,
                    IznosRacuna = 1404,
                    Kolicina = 7,
                    KorisnikId = 1,
                    DobavljacId = 2
                });
            #endregion

            #region Dodavanje stavki nabavke
            modelBuilder.Entity<NabavkaStavke>().HasData(
                new NabavkaStavke()
                {
                    NabavkaStavkeId = 1,
                    NabavkaId = 1,
                    ProizvodId = 1,
                    Kolicina = 1,
                    Cijena = 1200
                },
                new NabavkaStavke()
                {
                    NabavkaStavkeId = 2,
                    NabavkaId = 2,
                    ProizvodId = 2,
                    Kolicina = 1,
                    Cijena = 1200
                });
            #endregion

            #region Dodavanje narudzbi
            modelBuilder.Entity<Narudzba>().HasData(
                new Narudzba()
                {
                    NarudzbaId = 1,
                    BrojNarudzbe = "1",
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Status = true,
                    Otkazano = false,
                    IznosRacuna = 550

                },
                new Narudzba()
                {
                    NarudzbaId = 2,
                    BrojNarudzbe = "2",
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Status = true,
                    Otkazano = false,
                    IznosRacuna = 1000
                });
            #endregion

            #region Dodavanje stavki narudzbe
            modelBuilder.Entity<NarudzbaStavke>().HasData(
                new NarudzbaStavke()
                {
                    NarudzbaStavkaId = 1,
                    NarudzbaId = 1,
                    Kolicina = 1,
                    Cijena = 1200,
                    Popust = 10,
                    ProizvodId = 2
                },
                new NarudzbaStavke()
                {
                    NarudzbaStavkaId = 2,
                    NarudzbaId = 2,
                    Kolicina = 1,
                    Cijena = 900,
                    Popust = 0,
                    ProizvodId = 1,
                },
                new NarudzbaStavke()
                {
                    NarudzbaStavkaId = 3,
                    NarudzbaId = 2,
                    Kolicina = 1,
                    Cijena = 1800,
                    Popust = 0,
                    ProizvodId = 3,
                });
            #endregion

            #region Dodavanje ocjena
            modelBuilder.Entity<Ocjene>().HasData(
                new Ocjene()
                {
                    OcjenaId = 1,
                    ProizvodId = 2,
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Ocjena = 5
                },
                new Ocjene()
                {
                    OcjenaId = 2,
                    ProizvodId = 1,
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Ocjena = 7
                },
                new Ocjene()
                {
                    OcjenaId = 3,
                    ProizvodId = 2,
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Ocjena = 10
                });
            #endregion

            #region Dodavanje proizvodjaca
            modelBuilder.Entity<Proizvodjaci>().HasData(
                new Proizvodjaci()
                {
                    ProizvodjacId = 1,
                    Naziv = "Lenovo"
                },
                new Proizvodjaci()
                {
                    ProizvodjacId = 2,
                    Naziv = "HP"
                },
                new Proizvodjaci()
                {
                    ProizvodjacId = 3,
                    Naziv = "Apple"
                },
                new Proizvodjaci()
                {
                    ProizvodjacId = 4,
                    Naziv = "Alcatel"
                });
            #endregion
        }
    }
}
