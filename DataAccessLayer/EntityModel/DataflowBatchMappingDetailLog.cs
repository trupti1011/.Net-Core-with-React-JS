using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowBatchMappingDetailLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long? DataFlowBmdid { get; set; }
        public long? DataFlowBdid { get; set; }
        public long? DataFlowMid { get; set; }
        public int? ClientMid { get; set; }
        public string SourceTableName { get; set; }
        public string SourceColumnName { get; set; }
        public string SourceAlias { get; set; }
        public string DestinationTableName { get; set; }
        public string DestinationColumnName { get; set; }
        public string DestinationAlias { get; set; }
        public string JoinType { get; set; }
        public byte? Status { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
