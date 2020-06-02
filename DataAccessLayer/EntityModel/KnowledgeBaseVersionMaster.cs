using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseVersionMaster
    {
        public long Kbvmid { get; set; }
        public long Kbmid { get; set; }
        public string Name { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
        public string KnowledgeBaseType { get; set; }
        public long? Kbamid { get; set; }
        public long? Kbcmid { get; set; }
        public long? Kbsmid { get; set; }
        public int? CurrentStatus { get; set; }
        public string VersionLevel { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
