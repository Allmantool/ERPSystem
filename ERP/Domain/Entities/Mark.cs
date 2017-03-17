using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Марка оборудования
    /// </summary>
    public class Mark {
        public Mark() {
            this.Facilities = new HashSet<Facility>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
    }
}