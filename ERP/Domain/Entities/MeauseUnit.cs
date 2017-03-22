using System;
namespace ERP.Domain.Entities {
    public class MeauseUnit {
        public int Id { get; set; }
        public Type CLRType { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public bool IsSystem { get; set; }
    }
}