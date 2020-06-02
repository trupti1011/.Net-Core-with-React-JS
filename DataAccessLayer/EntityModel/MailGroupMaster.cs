using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MailGroupMaster
    {
        public int MailGroupMid { get; set; }
        public int? ClientMid { get; set; }
        public string MailGroupName { get; set; }
        public string MailFromId { get; set; }
        public string DisplayName { get; set; }
        public string MailUserId { get; set; }
        public string MailPassword { get; set; }
        public string MailIp { get; set; }
        public string MailPort { get; set; }
        public string Ipyes { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
