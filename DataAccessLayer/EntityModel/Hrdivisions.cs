using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Hrdivisions
    {
        public int HrdivisionMid { get; set; }
        public int? HrsourceDivisionId { get; set; }
        public string HrdivisionName { get; set; }
        public int? HrsystemSourcesMid { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte? FreezeStatus { get; set; }
        public Guid? BatchGuid { get; set; }
    }
}
