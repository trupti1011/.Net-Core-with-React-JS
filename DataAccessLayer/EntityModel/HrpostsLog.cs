using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class HrpostsLog
    {
        public int LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public int HrpostsMid { get; set; }
        public int? HrsourcePostId { get; set; }
        public string HrpostName { get; set; }
        public string HrpostRoleDescription { get; set; }
        public int? GlobalUserRoleTypeId { get; set; }
        public int? HrsystemSourcesMid { get; set; }
        public int? ClientMid { get; set; }
        public int? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public Guid? BatchGuid { get; set; }
    }
}
