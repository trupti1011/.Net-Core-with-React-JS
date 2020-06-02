using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TweetDetailsTemp
    {
        public long PostTempId { get; set; }
        public string PageUniqueId { get; set; }
        public string PostUniqueId { get; set; }
        public string Post { get; set; }
        public string PostFrom { get; set; }
        public DateTime? PostDateTime { get; set; }
        public byte? FreezeStatus { get; set; }
        public long? OriginalPostId { get; set; }
        public long? PageId { get; set; }
        public string MediaType { get; set; }
        public string MediaPathWeb { get; set; }
        public string MediaPathSystem { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
