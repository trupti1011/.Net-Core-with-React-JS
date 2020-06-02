using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SocialMediaComment
    {
        public long CommentId { get; set; }
        public string CommentUniqueId { get; set; }
        public string PostUniqueId { get; set; }
        public string Comment { get; set; }
        public long? ParentCommentId { get; set; }
        public byte? CommentLevel { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CommentFrom { get; set; }
        public DateTime? CommentDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public long? PostId { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
