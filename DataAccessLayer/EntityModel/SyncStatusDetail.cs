using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SyncStatusDetail
    {
        public long SyncSdid { get; set; }
        public int? SyncMdid { get; set; }
        public DateTime? DataStartDate { get; set; }
        public DateTime? DataEndDate { get; set; }
        public byte? SyncStatus { get; set; }
        public int? UpdatedCount { get; set; }
        public int? InsertedCount { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? ProcessStartTime { get; set; }
        public DateTime? ProcessEndTime { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
    }
}
