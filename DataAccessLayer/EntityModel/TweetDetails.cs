using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TweetDetails
    {
        public long PostId { get; set; }
        public long? PageId { get; set; }
        public string PostUniqueId { get; set; }
        public string Post { get; set; }
        public string PostFrom { get; set; }
        public DateTime? PostDateTime { get; set; }
        public string MediaType { get; set; }
        public string MediaPathWeb { get; set; }
        public string MediaPathSystem { get; set; }
        public long? UserId { get; set; }
        public byte? Status { get; set; }
        public string UniqueUserId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? Emotions { get; set; }
        public int? Sentiments { get; set; }
        public long? XmlrawId { get; set; }
    }
}
