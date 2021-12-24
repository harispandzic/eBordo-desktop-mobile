using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.Database
{
    public class eBordoContext : DbContext
    {
        public eBordoContext() { }

        public eBordoContext(DbContextOptions<eBordoContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);       

            modelBuilder.Entity<Korisnik>()
                .HasOne<Igrac>(s => s.igrac)
                .WithOne(ad => ad.korisnik)
                .HasForeignKey<Igrac>(ad => ad.korisnikId)
                ;

            modelBuilder.Entity<IgracStatistika>()
                .HasOne<Igrac>(s => s.igrac)
                .WithOne(ad => ad.igracStatistika)
                .HasForeignKey<Igrac>(ad => ad.igracStatistikaId)
                ;

            modelBuilder.Entity<IgracSkills>()
                .HasOne<Igrac>(s => s.igrac)
                .WithOne(ad => ad.igracSkills)
                .HasForeignKey<Igrac>(ad => ad.igracSkillsId)
                ;

            modelBuilder.Entity<Ugovor>()
                .HasOne<Igrac>(s => s.igrac)
                .WithOne(ad => ad.ugovor)
                .HasForeignKey<Igrac>(ad => ad.ugovorId)
                ;

            modelBuilder.Entity<Ugovor>()
                .HasOne<Trener>(s => s.trener)
                .WithOne(ad => ad.ugovor)
                .HasForeignKey<Trener>(ad => ad.ugovorId)
                ;

            modelBuilder.Entity<Korisnik>()
                .HasOne<Trener>(s => s.trener)
                .WithOne(ad => ad.korisnik)
                .HasForeignKey<Trener>(ad => ad.korisnikId)
                ;

            modelBuilder.Entity<TrenerStatistika>()
                .HasOne<Trener>(s => s.trener)
                .WithOne(ad => ad.trenerStatistika)
                .HasForeignKey<Trener>(ad => ad.trenerStatistikaId)
                ;
        }
        public virtual DbSet<Pozicija> pozicije { get; set; }
        public virtual DbSet<Drzava> drzave { get; set; }
        public virtual DbSet<Grad> gradovi { get; set; }
        public virtual DbSet<IgracSkills> igracSkills { get; set; }
        public virtual DbSet<IgracStatistika> igracStatistika { get; set; }
        public virtual DbSet<Ugovor> ugovori { get; set; }
        public virtual DbSet<Korisnik> korisnici { get; set; }
        public virtual DbSet<Igrac> igraci { get; set; }
        public virtual DbSet<TrenerStatistika> trenerStatistika { get; set; }
        public virtual DbSet<Formacija> formacije { get; set; }
        public virtual DbSet<TrenerskaLicenca> trenerskeLicence { get; set; }
        public virtual DbSet<Trener> treneri { get; set; }
        public virtual DbSet<Stadion> stadioni { get; set; }
        public virtual DbSet<Takmicenje> takmicenje { get; set; }
        public virtual DbSet<Klub> klubovi { get; set; }
        public virtual DbSet<UtakmicaSastav> utakmicaSastav { get; set; }
        public virtual DbSet<Utakmica> utakmice { get; set; }
        public virtual DbSet<UtakmicaNastup> utakmicaNastup { get; set; }
        public virtual DbSet<UtakmicaIzmjena> utakmicaIzmjena { get; set; }
        public virtual DbSet<Izvještaj> izvještaj { get; set; }
    }
}
