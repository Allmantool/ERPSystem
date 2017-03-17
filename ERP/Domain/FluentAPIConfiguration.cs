using System.Data.Entity.ModelConfiguration;

namespace ERP.Domain {
    public class FluentAPIGeneralConfiguration<T> : EntityTypeConfiguration<T> where T : class {
        public FluentAPIGeneralConfiguration() {

        }
    }
}