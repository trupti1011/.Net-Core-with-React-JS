using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DiallerExportConfigurationMasterDeepak
    {
        public long DiallerEcmid { get; set; }
        public int? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? DataFlowMid { get; set; }
        public long? MiscMid { get; set; }
        public string MiscColLabel { get; set; }
        public int? Columnlength { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public string ExportName { get; set; }
        public int? OrderId { get; set; }
        public string CustomizedColumn { get; set; }
        public int? DataExportTypeMid { get; set; }
    }
}
