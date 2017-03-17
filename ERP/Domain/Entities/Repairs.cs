using System;

namespace ERP.Domain.Entities {
    /// <summary>
    /// Ремонт
    /// </summary>
    public class Repairs {
        public DateTime Period { get; set; }
        public EnumWrkState State { get; set; }
        
        public EnumMaintenanceType PlanKind { get; set; }
        public EnumMaintenanceType FactKind { get; set; }

        public virtual Facility IdFacility { get; set; }
        public virtual RepairReason Cause { get; set; }
    }

    /// <summary>
    /// Вид ТО
    /// </summary>
    public enum EnumMaintenanceType : int {
        Inspection = 0,
        Routine = 1,
        Medium = 2,
        Heavy = 3
    }


    /// <summary>
    /// Текущее состояние
    /// </summary>
    public enum EnumWrkState {
        Complete = 0,
        Uncomplete = 1,
        Inprocces = 2,
    }
}