using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseFaqmapping
    {
        public long Kbfmmid { get; set; }
        public int? Kbfmid { get; set; }
        public int? Kbmid { get; set; }
        public int? Kbdid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
        public long? RefId { get; set; }
    }
}
