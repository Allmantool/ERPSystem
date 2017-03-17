using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Физическая среда
    /// </summary>
    public class PhEnvironment {
        public PhEnvironment() {
            this.Facilities = new HashSet<Facility>();
        }
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
    }
}