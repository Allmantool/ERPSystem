using System;
using ERP.Domain.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Domain.Entities {
    /// <summary>
    /// обобщенная ед. структуры (может быть видом, группой, подгруппой, типом, конкретной единицей оборудования и т.д)
    /// </summary>
    [Table("NodeUnit")]
    public class GeneralHierarchyUnit : Node<GeneralHierarchyUnit> {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}