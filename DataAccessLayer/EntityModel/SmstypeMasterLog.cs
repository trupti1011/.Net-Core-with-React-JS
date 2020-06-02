using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SmstypeMasterLog
    {
        public int LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int SmstypeMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public string Bucket { get; set; }
        public string Smstype { get; set; }
        public string Smstemplate { get; set; }
        public string AdditionalQuery { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
