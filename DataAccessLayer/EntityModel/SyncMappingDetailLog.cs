using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SyncMappingDetailLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public int? SyncMdid { get; set; }
        public int? SyncTmid { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public byte? FreezeStatus { get; set; }
        public int? RunDuration { get; set; }
    }
}
