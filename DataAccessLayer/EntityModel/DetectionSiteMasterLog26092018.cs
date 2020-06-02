using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DetectionSiteMasterLog26092018
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public int DetSmid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string SiteName { get; set; }
        public string Url { get; set; }
        public byte? AuthenticationRequired { get; set; }
        public bool? FixedLogin { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ControlUserName { get; set; }
        public string ControlPassword { get; set; }
        public string ControlLoginButton { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
