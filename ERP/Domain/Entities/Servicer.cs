namespace ERP.Domain.Entities {
    /// <summary>
    /// Персонал
    /// </summary>
    public class Servicer {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int ClockNumber { get; set; }
        public EnumJobs Position { get; set; }
    }

    /// <summary>
    /// Должность
    /// </summary>
    public enum EnumJobs : int {
        Mechanic = 0,
        Locksmith = 1
    }
}