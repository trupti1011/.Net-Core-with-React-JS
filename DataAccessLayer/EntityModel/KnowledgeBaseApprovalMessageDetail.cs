using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseApprovalMessageDetail
    {
        public long Kamid { get; set; }
        public long? Kbmid { get; set; }
        public byte? Status { get; set; }
        public byte? IsRead { get; set; }
        public string MessageTitle { get; set; }
        public string MessageText { get; set; }
        public byte Freezestatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
        public long? MessageCategoryId { get; set; }
        public int? Kbfmid { get; set; }
        public string MessageTypeName { get; set; }
    }
}
