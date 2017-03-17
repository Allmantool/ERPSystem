namespace ERP.Domain {
    using Entities;
   
    using System.Data.Entity;

    public class ERPMashinesDbContext : DbContext {
        // Your context has been configured to use a 'ERPMashines' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'ERP.Domain.ERPMashines' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'ERPMashines'
        // connection string in the application configuration file.
        public ERPMashinesDbContext() : base("name=ERPMashines") {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ERPMashinesDbContext>());

            //Custom initializer (test seed)
            Database.SetInitializer(new CustomDbInit<ERPMashinesDbContext>());

            //Disable initializer (production)
            //Database.SetInitializer<ERPMashinesDbContext>(null);

            // "enable-migrations –EnableAutomaticMigration:$true"
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDBContext, SchoolDataLayer.Migrations.Configuration>("SchoolDBConnectionString"));
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Index> Indexes { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<FactoryShop> Shops { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<EqGroup> EqGroups { get; set; }
        public virtual DbSet<KindEq> KindEqs { get; set; }
        public virtual DbSet<Servicer> Stuff { get; set; }
        public virtual DbSet<ProducerFactory> Factories { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //modelBuilder.Configurations.Add(new FluentAPIGeneralConfiguration<T>());

            modelBuilder.HasDefaultSchema("ERP");
            // Configure StudentId as PK for StudentAddress
            //modelBuilder.Entity<Index>()
            //    .HasKey(e => e.Id);
        }
    }
}