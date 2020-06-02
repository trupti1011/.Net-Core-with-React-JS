using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportFolder
    {
        public int ReportFid { get; set; }
        public int? ReportSid { get; set; }
        public string FolderName { get; set; }
        public string FolderPath { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public bool? FreezeStatus { get; set; }
    }
}
