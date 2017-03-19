using System.Collections.Generic;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Вид оборудования
    /// </summary>
    public sealed class KindEq {
        public KindEq() {
            this.EqGroups = new HashSet<EqGroup>();
        }
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<EqGroup> EqGroups { get; set; }
    }
}