using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Domain.Entities {
    public class StructNode {
        public StructNode() {
            SubModules = new List<StructNode>();
        }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public virtual int ParentModuleId { get; set; }

        // /1/2 (path by node id)
        public string Path { get; set; }
        public int Depth { get; set; }

        [ForeignKey("ParentModuleId")]
        public virtual ICollection<StructNode> SubModules { get; set; }
    }
}