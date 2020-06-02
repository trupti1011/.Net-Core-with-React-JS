using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseVersionDetailMappingLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long Kbvdmid { get; set; }
        public long Kbdmid { get; set; }
        public long? Kbdid { get; set; }
        public int? Kbmid { get; set; }
        public int? ParentKbdid { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
        public bool? IsCheck { get; set; }
        public string VersionLevel { get; set; }
        public string ParentKbvdid { get; set; }
    }
}
