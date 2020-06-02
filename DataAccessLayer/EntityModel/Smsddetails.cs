using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Smsddetails
    {
        public long Smsdid { get; set; }
        public long? DataDid { get; set; }
        public long? LoginMid { get; set; }
        public long? DispositionMid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public byte? SmssentFlag { get; set; }
        public int? SmssendCount { get; set; }
        public int? Smssource { get; set; }
        public int? SmstypeMid { get; set; }
        public long? RefDataDid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
    }
}
