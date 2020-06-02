using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowMasterisation
    {
        public long DataFlowMsid { get; set; }
        public long? DataFlowMid { get; set; }
        public long? DataFlowFcid { get; set; }
        public byte? ConfigType { get; set; }
        public long? MiscMid { get; set; }
        public string Value { get; set; }
        public byte? Status { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
