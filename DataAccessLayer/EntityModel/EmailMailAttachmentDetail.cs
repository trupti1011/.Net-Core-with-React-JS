using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailMailAttachmentDetail
    {
        public long Id { get; set; }
        public long? EmailDid { get; set; }
        public byte[] AttachmentFile { get; set; }
        public string AttachmentFileName { get; set; }
        public string ContentType { get; set; }
        public bool? IsInlineAttachment { get; set; }
        public DateTime? DownloadedOn { get; set; }
    }
}
