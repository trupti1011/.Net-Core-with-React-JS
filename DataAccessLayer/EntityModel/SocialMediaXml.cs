using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SocialMediaXml
    {
        public long Id { get; set; }
        public string Xmldata { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string PageUniqueId { get; set; }
        public string Createdby { get; set; }
        public string TokenId { get; set; }
        public string PageId { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public int? PostCount { get; set; }
        public int? CommentCount { get; set; }
        public int? ReplyCount { get; set; }
    }
}
