using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class BulkSmsddetailsLog
    {
        public long BulkSmslogMid { get; set; }
        public long? BulkSmsdid { get; set; }
        public long? DataDid { get; set; }
        public string Bucket { get; set; }
        public string State { get; set; }
        public string SmssentNumber { get; set; }
        public string Smstext { get; set; }
        public string SmsreturnCode { get; set; }
        public DateTime? SmssendDateTime { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
