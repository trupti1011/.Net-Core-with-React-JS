using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class LoginLogDetail
    {
        public long LoginLdid { get; set; }
        public long? LoginMid { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public long? TrackLoginLdid { get; set; }
        public long? TrackLoginMid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public byte? LoginState { get; set; }
        public int? LoginServerId { get; set; }
    }
}
