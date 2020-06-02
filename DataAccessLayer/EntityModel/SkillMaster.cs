using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SkillMaster
    {
        public long SkillMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public string SkillName { get; set; }
        public byte? OrderId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
