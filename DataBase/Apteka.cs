using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataBase
{
    public partial class Apteka : DbContext
    {
        public Apteka()
            : base("name=Apteka")
        {
        }

        public virtual DbSet<applications> applications { get; set; }
        public virtual DbSet<manufacturers> manufacturers { get; set; }
        public virtual DbSet<medicines> medicines { get; set; }
        public virtual DbSet<pharmacies> pharmacies { get; set; }
        public virtual DbSet<procurements> procurements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<applications>()
                .HasMany(e => e.procurements)
                .WithRequired(e => e.applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manufacturers>()
                .HasMany(e => e.medicines)
                .WithMany(e => e.manufacturers)
                .Map(m => m.ToTable("medicines_by_manufacturers").MapLeftKey("manufacturerId").MapRightKey("medicinceId"));

            modelBuilder.Entity<pharmacies>()
                .HasMany(e => e.applications)
                .WithRequired(e => e.pharmacies)
                .WillCascadeOnDelete(false);
        }
    }
}
