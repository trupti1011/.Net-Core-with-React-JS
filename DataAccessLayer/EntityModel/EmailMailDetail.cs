using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailMailDetail
    {
        public long Id { get; set; }
        public long? TicketDid { get; set; }
        public string FromEmailId { get; set; }
        public string ToEmailId { get; set; }
        public string CcEmailId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public DateTime? EmailDownloadDt { get; set; }
        public DateTime? EmailSentDt { get; set; }
        public bool? AutoResponseSent { get; set; }
        public bool? IsReplied { get; set; }
        public bool? Vip { get; set; }
        public int? MailboxId { get; set; }
        public bool? AutoAssign { get; set; }
        public bool? IsAttachment { get; set; }
        public bool? IsAssigned { get; set; }
        public int? PrimaryTicketDid { get; set; }
        public int? AssignedToId { get; set; }
        public DateTime? AssignedDateTime { get; set; }
        public byte? Status { get; set; }
        public byte? EmailType { get; set; }
        public byte? RequestType { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public int? PriorityMid { get; set; }
        public int? ActualSlabandMid { get; set; }
        public int? CurrentSlabandMid { get; set; }
        public DateTime? SlachangeDateTime { get; set; }
        public byte? MailSendType { get; set; }
        public DateTime? AssignedDateTimeUtc { get; set; }
        public DateTime? UpdatedDateTimeUtc { get; set; }
        public DateTime? SlachangeDateTimeUtc { get; set; }
    }
}
