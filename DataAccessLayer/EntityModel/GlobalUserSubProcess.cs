using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserSubProcess
    {
        public int GlobalUserSubProcessId { get; set; }
        public int GlobalUserId { get; set; }
        public int SubProcessMid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? FreezeStatus { get; set; }
        public bool? DefaultSubProcess { get; set; }
        public Guid? BatchGuid { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }

        public virtual GlobalUsers GlobalUser { get; set; }
    }
}
