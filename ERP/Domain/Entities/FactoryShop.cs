using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Цех, производство
    /// </summary>
    public class FactoryShop {
        public FactoryShop() {
            this.Facilities = new HashSet<Facility>();
            this.Plants = new HashSet<Plant>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }
    }
}