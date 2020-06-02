using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScriptMiscSettings
    {
        public long MiscParamMid { get; set; }
        public int? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
