namespace ERP.Domain {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public class ERPMashines : DbContext {
        // Your context has been configured to use a 'ERPMashines' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'ERP.Domain.ERPMashines' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'ERPMashines'
        // connection string in the application configuration file.
        public ERPMashines() : base("name=ERPMashines") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema("ERP");
            // Configure StudentId as PK for StudentAddress
            modelBuilder.Entity<Index>()
                .HasKey(e => e.Id);
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
    }


    /// <summary>
    /// Оборудование
    /// </summary>
    public class Facility {
        public int Id { get; set; }

        public int IdFacilityGroup { get; set; }

        [MaxLength(300)]
        public string Location { get; set; }
        public DateTime DueDate { get; set; }

        public bool IsUsed { get; set; }

        public virtual ICollection<Index> PersonalMarks { get; set; }
        public virtual Mark Mark { get; set; }
        public virtual FactoryShop Shop { get; set; }
        public virtual ProducerFactory ProducerFactory { get; set; }
        public virtual PhEnvironment PhEnvironment { get; set; }
    }

    /// <summary>
    /// Характеристика оборудования (единица)
    /// </summary>
    public class Index {
        [Key, ForeignKey("Facility")]
        public int Id { get; set; }
        public string Description { get; set; }
        //use reflection ? + maybe enum + string
        public Type dataType { get; set; }

        public virtual int IdFacility { get; set; }
    }

    /// <summary>
    /// Марка оборудования
    /// </summary>
    public class Mark {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
    }

    /// <summary>
    /// Цех, производство
    /// </summary>
    public class FactoryShop {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }
    }

    /// <summary>
    /// Установка
    /// </summary>
    public class Plant {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual int IdShop { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }

    /// <summary>
    /// Вид оборудования
    /// </summary>
    public class KindEq {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EqGroup> EqGroups { get; set; }
    }

    /// <summary>
    /// Группа оборудования
    /// </summary>
    public class EqGroup {
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual KindEq KindEq { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Index> GroupMarks { get; set; }
        public virtual ICollection<Standard> Standards { get; set; }
    }

    /// <summary>
    /// Персонал
    /// </summary>
    public class Servicer {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int ClockNumber { get; set; }
        public EnumJobs Position { get; set; }
    }

    /// <summary>
    /// Завод изготовитель
    /// </summary>
    public class ProducerFactory {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual Facility Facility { get; set; }
    }

    /// <summary>
    /// Физическая среда
    /// </summary>
    public class PhEnvironment {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
    }

    /// <summary>
    /// Рабочие нормы (показатели: нормы наработки и меж. ремонтного цикла)
    /// </summary>
    public class Standard {
        public struct Range {
            public int Min;
            public int Max;
        }

        public EnumRepairType RepairType { get; set; }

        public virtual EqGroup EqGroup { get; set; }
    }

    public enum EnumJobs : int {
        Mechanic = 0,
        Locksmith = 1
    }

    public enum EnumRepairType : int {
        Inspection = 0,
        Routine = 1,
        Medium = 2,
        Heavy = 3 
}