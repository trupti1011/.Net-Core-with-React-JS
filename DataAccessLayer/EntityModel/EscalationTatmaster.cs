using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EscalationTatmaster
    {
        public int Tatmid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public int? MiscDid { get; set; }
        public string MiscColName { get; set; }
        public string EscalationLevel { get; set; }
        public byte? EscalationOrder { get; set; }
        public int? Tatfrom { get; set; }
        public int? Tatto { get; set; }
        public string Type { get; set; }
        public string ColumnName { get; set; }
        public string TableName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
