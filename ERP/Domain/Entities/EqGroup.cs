using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Группа оборудования
    /// </summary>
    public class EqGroup {

        public EqGroup() {
            this.Facilities = new HashSet<Facility>();
            this.GroupMarks = new HashSet<Index>();
            this.Standards = new HashSet<Standard>();
        }
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual KindEq KindEq { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Index> GroupMarks { get; set; }
        public virtual ICollection<Standard> Standards { get; set; }
    }
}