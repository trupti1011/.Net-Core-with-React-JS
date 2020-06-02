using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ArIndexerDetails
    {
        public decimal ArindexerId { get; set; }
        public string InputCategory { get; set; }
        public string ExchachageHeader { get; set; }
        public string MessageId { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string MailSubject { get; set; }
        public string EmailReceivedTime { get; set; }
        public string Market { get; set; }
        public string Process { get; set; }
        public string SubQueue { get; set; }
        public int? NoOfAttchment { get; set; }
        public int? NoOfTransaction { get; set; }
        public string BatchId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }
        public bool? CompletedStatus { get; set; }
        public string CompletedDateTime { get; set; }
        public string EntryUser { get; set; }
        public string EntryDate { get; set; }
    }
}
