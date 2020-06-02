using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataFlowMasterLog
    {
        public int LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int? DataFlowMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public string DataFlowName { get; set; }
        public byte? UploadType { get; set; }
        public byte? ScrubbingRequired { get; set; }
        public byte? ExclusionRequired { get; set; }
        public byte? MasterCheckRequired { get; set; }
        public byte? ExternalDnc { get; set; }
        public byte? InternalDnc { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte? ActionType { get; set; }
        public int? DataFlowTypeMid { get; set; }
        public byte? DataUploadType { get; set; }
        public string DataUploadTableName { get; set; }
        public int? ExternalDataType { get; set; }
        public int? SearchDataType { get; set; }
    }
}
