﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class FileUploadMaster
    {
        public int FileUmid { get; set; }
        public int? ClientId { get; set; }
        public int? ScriptMid { get; set; }
        public string FilePath { get; set; }
        public string FilePathSystem { get; set; }
        public string FileName { get; set; }
        public string ActualFileName { get; set; }
        public byte? Status { get; set; }
        public int? Umid { get; set; }
        public int? RecordCount { get; set; }
        public int? ValidRecordCount { get; set; }
        public int? InValidRecordCount { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? UploadType { get; set; }
        public string HostName { get; set; }
        public DateTime? ProcessStartTime { get; set; }
        public DateTime? ProcessEndTime { get; set; }
        public DateTime? DataProcessDate { get; set; }
    }
}
