using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailTocMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public byte[] LogoFile { get; set; }
        public string SmtpServerIp { get; set; }
        public string Pop3ServerIp { get; set; }
        public int? Pop3Port { get; set; }
        public string Pop3EmailId { get; set; }
        public string Pop3EmailPassword { get; set; }
        public int? AutoResponseTat { get; set; }
        public string AutoResponseMessage { get; set; }
        public string AutoResponseSubject { get; set; }
        public string AwardLogo { get; set; }
        public string Pop3EmailUser { get; set; }
        public bool? Status { get; set; }
        public int? SmtpPort { get; set; }
        public bool? IsSecure { get; set; }
        public bool? ServiceDownload { get; set; }
        public string NreDescription { get; set; }
        public string NreIcon { get; set; }
    }
}
