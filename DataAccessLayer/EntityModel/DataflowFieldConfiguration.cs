using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowFieldConfiguration
    {
        public long DataFlowFcid { get; set; }
        public int? ScriptMid { get; set; }
        public long? DataFlowMid { get; set; }
        public string FieldName { get; set; }
        public int? DataType { get; set; }
        public byte? Mandatory { get; set; }
        public byte? Encryption { get; set; }
        public byte? IsUnique { get; set; }
        public byte? Masterisation { get; set; }
        public byte? Isgrouping { get; set; }
        public byte? InternalDnc { get; set; }
        public byte? ExternalDnc { get; set; }
        public string ScriptField { get; set; }
        public long? MiscMid { get; set; }
        public byte? PhoneNumber { get; set; }
        public byte? FieldType { get; set; }
        public byte? CustomRuletype { get; set; }
        public string CustomRule { get; set; }
        public byte? Status { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte? AllocationRequired { get; set; }
        public byte? GridDisplay { get; set; }
    }
}
