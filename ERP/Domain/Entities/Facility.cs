using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Оборудование
    /// </summary>
    public class Facility {
        public Facility() {
            this.PersonalMarks = new HashSet<Index>();
            this.Repairs = new HashSet<Repairs>();
            this.WrkRegisters = new HashSet<WrkRegister>();
        }

        public int Id { get; set; }

        [MaxLength(300)]
        public string Location { get; set; }
        public DateTime DueDate { get; set; }

        public bool IsUsed { get; set; }

        public virtual ICollection<Index> PersonalMarks { get; set; }
        public virtual ICollection<Repairs> Repairs { get; set; }
        public virtual ICollection<WrkRegister> WrkRegisters { get; set; }
        public virtual Mark Mark { get; set; }
        public virtual FactoryShop Shop { get; set; }
        public virtual ProducerFactory ProducerFactory { get; set; }
        public virtual PhEnvironment PhEnvironment { get; set; }
    }
}