using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataFlowUploadMaster
    {
        public int FileMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? DataFlowMid { get; set; }
        public long? DataFlowBdid { get; set; }
        public int? NoOfFiles { get; set; }
        public string FilePath { get; set; }
        public string FilePathSystem { get; set; }
        public string FileName { get; set; }
        public string FileNameSystem { get; set; }
        public int? TotalRecords { get; set; }
        public int? ValidRecordCount { get; set; }
        public int? InValidRecordCount { get; set; }
        public string DbtableName { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte? ExecutionStatus { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public DateTime? ExecutionStartDateTime { get; set; }
        public DateTime? ExecutionEndDateTime { get; set; }
    }
}
