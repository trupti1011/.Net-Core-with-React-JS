using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseAttachmentDetail
    {
        public long Kbadid { get; set; }
        public long? Kbdid { get; set; }
        public string FileType { get; set; }
        public string ActualFileName { get; set; }
        public string FileName { get; set; }
        public string Filepath { get; set; }
        public int? ParentNode { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
    }
}
