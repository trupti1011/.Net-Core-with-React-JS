using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseVersionMasterLog
    {
        public int LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long Kbvmid { get; set; }
        public long Kbmid { get; set; }
        public string Name { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
        public long? Kbamid { get; set; }
        public long? Kbcmid { get; set; }
        public long? Kbsmid { get; set; }
        public int? CurrentStatus { get; set; }
        public string VersionLevel { get; set; }
    }
}
