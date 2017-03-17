using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Domain.Entities {
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

}