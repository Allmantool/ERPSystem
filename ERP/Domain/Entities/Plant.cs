using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Установка
    /// </summary>
    public class Plant {
        public Plant() {
            this.Facilities = new HashSet<Facility>();
        }
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual int IdShop { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}