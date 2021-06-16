using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Moneypulate
{
    public partial class CatatanModel : DbContext
    {
        public CatatanModel()
            : base("name=CatatanModel")
        {
        }

        public virtual DbSet<Catatan> Catatans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catatan>()
                .Property(e => e.Penghasilan)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Catatan>()
                .Property(e => e.Pengeluaran)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Catatan>()
                .Property(e => e.DanaDarurat)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Catatan>()
                .Property(e => e.DanaInvestasi)
                .HasPrecision(18, 3);
        }
    }
}
