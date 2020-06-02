using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SocialMediaPost
    {
        public long PostId { get; set; }
        public string PageUniqueId { get; set; }
        public string PostUniqueId { get; set; }
        public string Post { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string PostFrom { get; set; }
        public DateTime? PostDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public long? PageId { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
