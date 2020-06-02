using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SocialMediaPageConfigurationLog
    {
        public long PageLogId { get; set; }
        public long? PageId { get; set; }
        public string PageUniqueId { get; set; }
        public string PageName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long? ScriptMid { get; set; }
        public long? ClientMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public string AccessToken { get; set; }
        public string TokenKey { get; set; }
        public DateTime? TokenExpiryDate { get; set; }
        public string AppId { get; set; }
        public byte? Type { get; set; }
        public string AccessTokenSecret { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
    }
}
