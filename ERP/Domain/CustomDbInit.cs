using System.Data.Entity;

namespace ERP.Domain {
    public class CustomDbInit<T> : CreateDatabaseIfNotExists<T> where T : DbContext {
        protected override void Seed(T context) {
            //IList<Standard> defaultStandards = new List<Standard>();

            //defaultStandards.Add(new Standard() { StandardName = "Standard 1", Description = "First Standard" });
            //defaultStandards.Add(new Standard() { StandardName = "Standard 2", Description = "Second Standard" });
            //defaultStandards.Add(new Standard() { StandardName = "Standard 3", Description = "Third Standard" });

            //foreach (Standard std in defaultStandards)
            //    context.Standards.Add(std);

            base.Seed(context);
        }
    }
}