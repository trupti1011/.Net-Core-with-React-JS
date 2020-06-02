using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportDumpPackMaster
    {
        public long ReportId { get; set; }
        public string ReportName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ScriptMid { get; set; }
        public string ParentGlobalUserId { get; set; }
        public string GlobalUserId { get; set; }
        public string LoginMid { get; set; }
        public int? AccessType { get; set; }
        public byte? FileStatus { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string HostName { get; set; }
        public DateTime? SystemDateTime { get; set; }
        public DateTime? SystemUpdatedDateTime { get; set; }
        public byte? WebFileStatus { get; set; }
    }
}
