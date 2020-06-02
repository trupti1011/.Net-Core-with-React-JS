using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseFaqaccessDetails
    {
        public long AccessDid { get; set; }
        public long? SearchDid { get; set; }
        public long? Kbfmid { get; set; }
        public long? ClientMid { get; set; }
        public long? LoginId { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
    }
}
