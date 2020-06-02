using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class LoginMaster17072018
    {
        public long LoginMid { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public int? AccessLmid { get; set; }
        public string EmailId { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeName { get; set; }
        public byte? BlockedStatus { get; set; }
        public DateTime? BlockedOn { get; set; }
        public byte? BlockCount { get; set; }
        public string Remarks { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? Status { get; set; }
        public string GlobalEmployeeId { get; set; }
        public string GlobalUserId { get; set; }
        public int? LoginType { get; set; }
        public long? MailValue { get; set; }
        public byte? FirstLoginStatus { get; set; }
        public DateTime? PasswordUpdatedDatetime { get; set; }
        public byte? AccessGrp { get; set; }
        public bool? Adauthentication { get; set; }
        public int? Admid { get; set; }
        public string AdloginName { get; set; }
        public int? DefaultClientMid { get; set; }
        public int? DefaultProcessMid { get; set; }
        public int? DefaultSubProcessMid { get; set; }
        public int? DefaultScriptMid { get; set; }
        public byte? WebMenuStatus { get; set; }
        public byte? AppMenuStatus { get; set; }
        public byte? WebsiteAccessType { get; set; }
        public long? BatchMid { get; set; }
        public string SaltKey { get; set; }
    }
}
