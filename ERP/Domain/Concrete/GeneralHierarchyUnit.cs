
using ERP.Domain.Concrete;

namespace ERP.Domain.Entities {
    /// <summary>
    /// обобщеная ед. структуры (может быть видом, группой, подгруппой, типом, конкретной единицей оборудования и т.д)
    /// </summary>
    public class GeneralHierarchyUnit : Node<GeneralHierarchyUnit> {
        public int Id { get; set; }
        public int Description { get; set; }
    }
}