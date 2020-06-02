using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TeamUserMappingDetailLog
    {
        public int LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? MappingMid { get; set; }
        public long? ClientMid { get; set; }
        public long? TeamMid { get; set; }
        public long? GlobalUserId { get; set; }
        public long? LoginMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
