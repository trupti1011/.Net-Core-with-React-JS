using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReTweetDetails
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
        public string MediaType { get; set; }
        public string MediaPathWeb { get; set; }
        public string MediaPathSystem { get; set; }
        public string UserId { get; set; }
        public byte? Status { get; set; }
        public string UniqueUserId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? Emotions { get; set; }
        public int? Sentiments { get; set; }
        public long? XmlRawId { get; set; }
    }
}
