using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseDetail
    {
        public long Kbdid { get; set; }
        public int? Kbmid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? ParentNode { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
        public bool? IsCheck { get; set; }
        public long? FreezeStatus { get; set; }
        public string ArticleNo { get; set; }
        public string Vid { get; set; }
        public long? RefId { get; set; }
    }
}
