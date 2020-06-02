using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailStatusDetail
    {
        public long EmailSdid { get; set; }
        public long? TicketDid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public int? MailBoxId { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public byte? EmailStatus { get; set; }
        public byte? EmailType { get; set; }
        public byte? RequestType { get; set; }
        public DateTime? CreateddateTime { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string Password { get; set; }
        public long? EmailDid { get; set; }
        public byte? TicketClosedCofirm { get; set; }
        public byte? EmailSendStatus { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public DateTime? UpdatedDateTimeUtc { get; set; }
    }
}
