using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailMailBox
    {
        public int Id { get; set; }
        public int ClientMid { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public byte[] LogoFile { get; set; }
        public string Pop3EmailId { get; set; }
        public string Pop3EmailUser { get; set; }
        public string Pop3EmailPassword { get; set; }
        public string Pop3ServerIp { get; set; }
        public int? Pop3Port { get; set; }
        public string ServerType { get; set; }
        public bool? IsSecure { get; set; }
        public string SmtpEmailId { get; set; }
        public string SmtpEmailUser { get; set; }
        public string SmtpEmailPassword { get; set; }
        public string SmtpServerIp { get; set; }
        public int? SmtpPort { get; set; }
        public string SmtpServerType { get; set; }
        public bool? SmtpIsSecure { get; set; }
        public bool? ServiceDownload { get; set; }
        public bool? AutoAssign { get; set; }
        public string AwardLogo { get; set; }
        public string NreDescription { get; set; }
        public string NreIcon { get; set; }
        public int? AutoResponseTat { get; set; }
        public string AutoResponseMessage { get; set; }
        public string AutoResponseSubject { get; set; }
        public bool? Status { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public byte? AutoDelete { get; set; }
        public bool? Processing { get; set; }
        public DateTime? ProcessingDate { get; set; }
    }
}
