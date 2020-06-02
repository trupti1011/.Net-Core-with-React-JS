using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Emaildetails06092016
    {
        public long Id { get; set; }
        public long TicketMasterId { get; set; }
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
        public int? TocId { get; set; }
        public bool? AutoAssign { get; set; }
        public bool? IsAttachment { get; set; }
        public bool? IsAssigned { get; set; }
    }
}
