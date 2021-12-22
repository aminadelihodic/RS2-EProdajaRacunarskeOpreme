using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Database
{
    public partial class MojDbContext : DbContext
    {
        public MojDbContext()
        {
        }

        public MojDbContext(DbContextOptions<MojDbContext> options)
            : base(options)
        {
        }

        public DbSet<Database.Klijenti> Klijenti { get; set; }
        public DbSet<Database.Ocjene> Ocjene { get; set; }
        public DbSet<Database.Proizvodi> Proizvodi { get; set; }
        public DbSet<Database.Proizvodjaci> Proizvodjaci { get; set; }
        public DbSet<Database.VrsteProizvoda> VrsteProizvoda { get; set; }
        public DbSet<Database.Karakteristike> Karakteristike { get; set; }
        public DbSet<Database.Dobavljaci> Dobavljaci { get; set; }
        public DbSet<Database.KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Database.Nabavka> Nabavka { get; set; }
        public DbSet<Database.NabavkaStavke> NabavkaStavke { get; set; }
        public DbSet<Database.Narudzba> Narudzba { get; set; }
        public DbSet<Database.NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<Database.Uloge> Uloge { get; set; }
        public DbSet<Database.Korisnici> Korisnici { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<VrsteProizvoda>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email);

                entity.Property(e => e.Telefon);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired();

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired();

            });



            modelBuilder.Entity<Proizvodi>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired();

                entity.Property(e => e.Sifra)
                    .IsRequired();

                entity.Property(e => e.Cijena)
                    .IsRequired();

                entity.Property(e => e.Slika);

                entity.Property(e => e.SlikaThumb);

                entity.Property(e => e.Status)
                    .IsRequired();

                entity.HasOne(d => d.VrstaProizvoda)
                   .WithMany(p => p.Proizvodi)
                   .HasForeignKey(d => d.VrstaProizvodaId)
                   .HasConstraintName("FK__ProizvodiVrsteProizvoda__VrsteProizvodaId__267ABA7A");

                

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Proizvodi)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .HasConstraintName("FK__ProizvodjaciProizvodi__ProizvodjacId__267ABA7A");
            });

            modelBuilder.Entity<Karakteristike>(entity =>
            {
                entity.Property(e => e.Novo);

                entity.Property(e => e.OperativniSistem)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VelicinaEkrana)
                    .IsRequired();

                entity.Property(e => e.Ram).IsRequired();

                entity.Property(e => e.Memorija).IsRequired();

                entity.Property(e => e.Procesor)
                    .IsRequired();

            });

            modelBuilder.Entity<Klijenti>(entity =>
            {
                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumRegistracije);

                entity.Property(e => e.Email);

                entity.Property(e => e.Telefon);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired();

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired();

            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.Property(e => e.Datum);

                entity.Property(e => e.Ocjena)
                    .IsRequired();

                entity.HasOne(d => d.Proizvodi)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.ProizvodId)
                    .HasConstraintName("FK__OcjeneProizvodi_ProizvodId__267ABA7A");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__OcjeneKlijent_KlijentId__267ABA7A");
            });

            modelBuilder.Entity<Nabavka>(entity =>
            {
                entity.Property(e => e.BrojNabavke)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum)
                    .IsRequired();

                entity.Property(e => e.IznosRacuna)
                    .IsRequired();


                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.Nabavka)
                    .HasForeignKey(d => d.DobavljacId)
                    .HasConstraintName("FK__NabavkaDobavljaci_DobavljacId__267ABA7A");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Nabavka)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__NabavkaKorisnik_KorisnikId__267ABA7A");

            });

            modelBuilder.Entity<NabavkaStavke>(entity =>
            {
                entity.Property(e => e.Kolicina)
                    .IsRequired();

                entity.Property(e => e.Cijena)
                    .IsRequired();

                entity.HasOne(d => d.Proizvodi)
                    .WithMany(p => p.NabavkaStavke)
                    .HasForeignKey(d => d.ProizvodId)
                    .HasConstraintName("FK__NabavkaStavkeProizvod__ProizvodId__267ABA7A");

                entity.HasOne(d => d.Nabavka)
                    .WithMany(p => p.NabavkaStavke)
                    .HasForeignKey(d => d.NabavkaId)
                    .HasConstraintName("FK__NabavkaStavke__NabavkaId__267ABA7A");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.BrojNarudzbe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum);

                entity.Property(e => e.Status);

                entity.Property(e => e.Otkazano)
                    .IsRequired();

                entity.Property(e => e.IznosRacuna).IsRequired();

                
                entity.Property(e => e.Status)
                    .IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Narudzbe)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__KlijentiNarudzbe_KlijentId__267ABA7A");

                


            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.Property(e => e.Kolicina)
                    .IsRequired();

                entity.Property(e => e.Cijena)
                    .IsRequired();

                entity.Property(e => e.Popust);

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.ProizvodId)
                    .HasConstraintName("FK__NarudzbaStavkeProizvod__ProizvodId__267ABA7A");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .HasConstraintName("FK__NarudzbaStavke__NarudzbaId__267ABA7A");
            });

           
            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Opis)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.Property(e => e.DatumIzmjene)
                    .IsRequired();


                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__KorisnikUloga_KorisnikId__267ABA7A");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK__KorisnikUloga_UlogaId__267ABA7A");
            });

            modelBuilder.Entity<Proizvodjaci>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });



            OnModelCreatingPartial(modelBuilder);

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
