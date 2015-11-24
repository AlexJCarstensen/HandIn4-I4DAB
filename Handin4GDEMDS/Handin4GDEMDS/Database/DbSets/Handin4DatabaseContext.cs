namespace Handin4GDEMDS.Database.DbSets
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Handin4DatabaseContext : DbContext
    {
        public Handin4DatabaseContext()
            : base("name=Handin4DatabaseContext3")
        {
        }

        public virtual DbSet<AppartmentcharacteristicSet> AppartmentcharacteristicSet { get; set; }
        public virtual DbSet<ReadingSet> ReadingSet { get; set; }
        public virtual DbSet<SensorcharacteristicSet> SensorcharacteristicSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppartmentcharacteristicSet>()
                .HasMany(e => e.ReadingSet)
                .WithRequired(e => e.AppartmentcharacteristicSet)
                .HasForeignKey(e => e.appartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppartmentcharacteristicSet>()
                .HasMany(e => e.SensorcharacteristicSet)
                .WithOptional(e => e.AppartmentcharacteristicSet)
                .HasForeignKey(e => e.Appartmentcharacteristic_appartmentId);

            modelBuilder.Entity<SensorcharacteristicSet>()
                .HasMany(e => e.ReadingSet)
                .WithRequired(e => e.SensorcharacteristicSet)
                .HasForeignKey(e => e.SensorID)
                .WillCascadeOnDelete(false);
        }
    }
}
