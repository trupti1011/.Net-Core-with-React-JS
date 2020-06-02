using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserSkillMapping
    {
        public int GlobalUserSkillMid { get; set; }
        public int? GlobalUserId { get; set; }
        public int? LoginMid { get; set; }
        public int? SkillMid { get; set; }
        public int? ClientMid { get; set; }
        public byte? OrderId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
