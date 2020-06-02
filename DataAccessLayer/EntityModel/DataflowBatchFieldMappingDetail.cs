using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowBatchFieldMappingDetail
    {
        public long DataFlowBfmid { get; set; }
        public long? DataFlowBdid { get; set; }
        public long? DataFlowMid { get; set; }
        public int? ClientMid { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public long? DataFlowFcid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
