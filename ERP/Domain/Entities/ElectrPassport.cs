using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Электронный паспорт
    /// </summary>
    public class ElectrPassport {
        public ElectrPassport() {
            indexes = new HashSet<Index>();
            Standards = new HashSet<Standard>();
            RepairsJournal = new HashSet<Repairs>();
            SubSystems = new HashSet<Facility>();
        }

        public virtual Facility Facility { get; set; }
        public virtual ICollection<Index> indexes { get; set; }
        public virtual ICollection<Standard> Standards { get; set; }
        public virtual ICollection<Facility> SubSystems { get; set; }
        public virtual ICollection<Repairs> RepairsJournal { get; set; }
    }
}