using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReTweetDetailsTemp
    {
        public long TempCommentId { get; set; }
        public string CommentUniqueId { get; set; }
        public string PostUniqueId { get; set; }
        public string Comment { get; set; }
        public long? ParentCommentId { get; set; }
        public byte? CommentLevel { get; set; }
        public string CommentFrom { get; set; }
        public DateTime? CommentDateTime { get; set; }
        public byte? FreezeStatus { get; set; }
        public string ReplyId { get; set; }
        public string PageUniqueId { get; set; }
        public long? OriginalCommentId { get; set; }
        public long? PostId { get; set; }
        public string MediaType { get; set; }
        public string MediaPathWeb { get; set; }
        public string MediaPathSystem { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
