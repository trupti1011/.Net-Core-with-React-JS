using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class PriorityMaster
    {
        public int PriorityMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string Priority { get; set; }
        public byte? PriorityOrder { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
