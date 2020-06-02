using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseStatusHistory
    {
        public long Kbshmid { get; set; }
        public long? Kbmid { get; set; }
        public long? Status { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
        public string Kbname { get; set; }
    }
}
