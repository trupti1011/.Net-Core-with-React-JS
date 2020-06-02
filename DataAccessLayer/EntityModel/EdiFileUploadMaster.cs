using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiFileUploadMaster
    {
        public int FileUmid { get; set; }
        public int? UploadMid { get; set; }
        public string FilePath { get; set; }
        public string FilePathSystem { get; set; }
        public string FileName { get; set; }
        public string ActualFileName { get; set; }
        public int? RecordCount { get; set; }
        public int? ValidRecordCount { get; set; }
        public int? InvalidRecordCount { get; set; }
        public DateTime? ProcessStartDate { get; set; }
        public DateTime? ProcessEndDate { get; set; }
        public string ClientMid { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
