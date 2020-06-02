using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DiallerLoginLogDetail
    {
        public long DiallerLldid { get; set; }
        public string LoginName { get; set; }
        public string Extension { get; set; }
        public string ServiceId { get; set; }
        public string PortalId { get; set; }
        public long? LoginMid { get; set; }
        public long? ScriptMid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LogOuttime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
    }
}
