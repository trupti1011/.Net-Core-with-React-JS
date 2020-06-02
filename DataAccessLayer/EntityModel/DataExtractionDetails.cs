using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataExtractionDetails
    {
        public long DataExtractDid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public long? DataSearchDid { get; set; }
        public int? DataExportTypeMid { get; set; }
        public long? DataDid { get; set; }
        public long? LastDispositionMid { get; set; }
        public DateTime? LastCallDateTime { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
    }
}
