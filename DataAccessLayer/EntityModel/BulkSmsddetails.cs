using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class BulkSmsddetails
    {
        public long BulkSmsdid { get; set; }
        public long? DataDid { get; set; }
        public string Bucket { get; set; }
        public string State { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public byte? SmssentFlag { get; set; }
        public int? SmssendCount { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
