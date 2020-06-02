using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseDetailMapping
    {
        public long Kbdmid { get; set; }
        public int? Kbmid { get; set; }
        public int? Kbdid { get; set; }
        public int? ParentKbdid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
        public bool? IsCheck { get; set; }
        public string Vid { get; set; }
        public long? RefId { get; set; }
    }
}
