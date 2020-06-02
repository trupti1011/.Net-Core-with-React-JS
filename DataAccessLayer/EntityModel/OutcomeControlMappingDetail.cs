using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class OutcomeControlMappingDetail
    {
        public long MappingDid { get; set; }
        public int? SubOutcomeMid { get; set; }
        public long? MiscMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public int? ClientMid { get; set; }
    }
}
