using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseAccessLevelMappingLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int Kbalmid { get; set; }
        public int? Kbmid { get; set; }
        public int? AccessLmid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
    }
}
