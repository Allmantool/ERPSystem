namespace ERP.Domain.Entities {
    /// <summary>
    /// Завод изготовитель
    /// </summary>
    public class ProducerFactory {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual Facility Facility { get; set; }
    }
}