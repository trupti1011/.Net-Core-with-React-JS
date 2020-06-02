using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserScript
    {
        public int GlobalUserScriptId { get; set; }
        public int GlobalUserId { get; set; }
        public int ScriptMid { get; set; }
        public bool? DefaultScript { get; set; }
        public byte? IsDiallerApplicable { get; set; }
        public byte? FreezeStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? ClientMid { get; set; }
        public byte? DiallerMode { get; set; }
        public int? ManualServiceId { get; set; }
        public int? PreviewServiceId { get; set; }
    }
}
