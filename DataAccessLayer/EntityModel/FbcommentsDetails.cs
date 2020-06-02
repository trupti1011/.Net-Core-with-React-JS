using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class FbcommentsDetails
    {
        public long CommentId { get; set; }
        public string CommentUniqueId { get; set; }
        public long? PostId { get; set; }
        public string PostUniqueId { get; set; }
        public long? ParentCommentId { get; set; }
        public string Comment { get; set; }
        public byte? CommentLevel { get; set; }
        public string CommentFrom { get; set; }
        public DateTime? CommentDateTime { get; set; }
        public byte? MediaType { get; set; }
        public string MediaPathWeb { get; set; }
        public string MediaPathSystem { get; set; }
        public string VideoId { get; set; }
        public long? UserId { get; set; }
        public string UniqueUserId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
