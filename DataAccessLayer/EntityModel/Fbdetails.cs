using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Fbdetails
    {
        public long PostId { get; set; }
        public string PageUniqueId { get; set; }
        public long? PageId { get; set; }
        public string PostUniqueId { get; set; }
        public string Post { get; set; }
        public string PostFrom { get; set; }
        public string PostDateTime { get; set; }
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
