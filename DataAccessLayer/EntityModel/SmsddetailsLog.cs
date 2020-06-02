using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SmsddetailsLog
    {
        public long SmslogMid { get; set; }
        public long? Smsdid { get; set; }
        public long? DataDid { get; set; }
        public string SmssentNumber { get; set; }
        public string Smstext { get; set; }
        public string SmsreturnCode { get; set; }
        public DateTime? SmssendDateTime { get; set; }
        public string Smstype { get; set; }
        public int? Smssource { get; set; }
        public int? SmstypeMid { get; set; }
        public long? RefDataDid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
    }
}
