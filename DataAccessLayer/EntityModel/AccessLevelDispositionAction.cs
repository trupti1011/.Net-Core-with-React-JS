using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccessLevelDispositionAction
    {
        public long AccessLevelDispositionAid { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? AccessLevel { get; set; }
        public long? DispositionMid { get; set; }
        public int? Action { get; set; }
        public long? NextLevelAccessLevel { get; set; }
        public long? NextLevelAction { get; set; }
        public byte? IsFreshData { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
