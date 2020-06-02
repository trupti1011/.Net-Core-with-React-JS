using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MilestoneDetails
    {
        public long MilestoneDid { get; set; }
        public byte? RequestType { get; set; }
        public long? TicketDid { get; set; }
        public long? MiscDid { get; set; }
        public string MilestoneName { get; set; }
        public string Reference { get; set; }
        public string AddedBy { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentFileName { get; set; }
        public string ContentType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
