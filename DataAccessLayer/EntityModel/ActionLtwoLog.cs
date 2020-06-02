using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ActionLtwoLog
    {
        public long ActionLogId { get; set; }
        public string LogCreatedBy { get; set; }
        public long? ActionId { get; set; }
        public byte? RequestType { get; set; }
        public long? TicketDid { get; set; }
        public string Chmnumber { get; set; }
        public string Comment { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentFileName { get; set; }
        public string ContentType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public long? CallHistoryMid { get; set; }
    }
}
