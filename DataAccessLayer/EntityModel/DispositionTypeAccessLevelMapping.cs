using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DispositionTypeAccessLevelMapping
    {
        public long MappingMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? AccessLmid { get; set; }
        public int? DispositionTypeMid { get; set; }
        public bool? DefaultDispositionType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
