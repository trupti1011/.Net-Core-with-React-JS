using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScriptMailing
    {
        public long MailId { get; set; }
        public long? ScriptMid { get; set; }
        public string DisplayName { get; set; }
        public string MailFrom { get; set; }
        public string Password { get; set; }
        public string MailTo { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Signature { get; set; }
        public string SignatureImage { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public long? ClientMid { get; set; }
    }
}
