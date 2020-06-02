using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TwitterUserMaster
    {
        public long UserId { get; set; }
        public string UniqueUserId { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
        public byte? Status { get; set; }
        public string ProfilePicUrlweb { get; set; }
        public string ProfilePicUrlsystem { get; set; }
        public long? PageId { get; set; }
    }
}
