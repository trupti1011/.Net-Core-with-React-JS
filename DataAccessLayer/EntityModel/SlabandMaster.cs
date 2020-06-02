using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SlabandMaster
    {
        public int SlabandMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string Slaband { get; set; }
        public string Slalabel { get; set; }
        public int? TimeFrom { get; set; }
        public int? TimeTo { get; set; }
        public int? PriorityMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
