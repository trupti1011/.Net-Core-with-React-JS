using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataSearchDetailsLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long DataSearchDid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? DataExportTypeMid { get; set; }
        public string SearchText { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public DateTime? UpdatedDateTimeUtc { get; set; }
        public DateTime? LogCreatedDateTimeUtc { get; set; }
    }
}
