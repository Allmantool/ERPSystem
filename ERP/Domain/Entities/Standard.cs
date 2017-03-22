namespace ERP.Domain.Entities {
    /// <summary>
    /// Рабочие нормативы (показатели: нормы наработки и меж. ремонтного цикла)
    /// </summary>
    public class Standard {
        public struct Range {
            public int Min;
            public int Max;
        }

        public int Value { get; set; }

        public EnumMaintenanceType RepairType { get; set; }

        public virtual EqGroup EqGroup { get; set; }
    }
}