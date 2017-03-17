using System;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Наработка оборудования за определенный период (час)
    /// </summary>
    public class WrkRegister {
        public DateTime Period { get; set; }
        public int Value { get; set; }

        public virtual Facility IdFacility { get; set; }
    }
}