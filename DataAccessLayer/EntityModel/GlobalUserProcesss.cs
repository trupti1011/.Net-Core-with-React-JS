using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserProcesss
    {
        public int GlobalUserProcessId { get; set; }
        public int GlobalUserId { get; set; }
        public int ProcessMid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? FreezeStatus { get; set; }
        public bool? DefaultProcess { get; set; }
        public Guid? BatchGuid { get; set; }
        public int? ClientMid { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string HostName { get; set; }

        public virtual GlobalUsers GlobalUser { get; set; }
    }
}
