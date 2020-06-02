using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowBatchDetail
    {
        public long DataFlowBdid { get; set; }
        public long? DataFlowMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string BatchName { get; set; }
        public byte? NofOfFiles { get; set; }
        public string TableLists { get; set; }
        public string MainQuery { get; set; }
        public string ExlusionTableName { get; set; }
        public string MasterisationTableName { get; set; }
        public byte? Status { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public long? ValidData { get; set; }
        public long? InValidData { get; set; }
        public long? TotalData { get; set; }
        public long? ExcludedData { get; set; }
    }
}
