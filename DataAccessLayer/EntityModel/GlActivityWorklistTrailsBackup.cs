using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlActivityWorklistTrailsBackup
    {
        public decimal GlactivityWorklistTrailsId { get; set; }
        public decimal GltaskMasterId { get; set; }
        public string StartTime { get; set; }
        public string Disposition { get; set; }
        public string Remarks { get; set; }
        public string EndTime { get; set; }
        public string EntryUser { get; set; }
        public string NextRunDate { get; set; }
        public bool? CompletedStatus { get; set; }
        public string CompletedDateTime { get; set; }
        public string BackupDate { get; set; }
        public string BackupUser { get; set; }
        public string Responsibility { get; set; }
    }
}
