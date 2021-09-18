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

            modelBuilder.Entity<Grad>()
               .HasOne<Drzava>(s => s.drzava)
               ;
        }

        public virtual DbSet<Drzava> drzave { get; set; }
        public virtual DbSet<Grad> gradovi { get; set; }
    }
}
