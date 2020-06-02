using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Hrdepartments
    {
        public int HrdepartmentMid { get; set; }
        public int? HrsourceDepartmentId { get; set; }
        public string HrdepartmentName { get; set; }
        public int? HrsystemSourcesMid { get; set; }
        public int? ClientMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public Guid? BatchGuid { get; set; }
    }
}
