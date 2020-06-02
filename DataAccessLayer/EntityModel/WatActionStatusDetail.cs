using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WatActionStatusDetail
    {
        public long StatusDid { get; set; }
        public long LoginMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? ClientMid { get; set; }
        public byte ActionSmid { get; set; }
        public long? ActiveWorkStatusDid { get; set; }
        public byte? ActiveWorkStatus { get; set; }
        public DateTime? ActionStartDateTime { get; set; }
        public DateTime? ActionEndDateTime { get; set; }
        public int? ElapsedTime { get; set; }
        public string ActionComments { get; set; }
        public DateTime? ActionStartDateTimeUtc { get; set; }
        public DateTime? ActionEndDateTimeUtc { get; set; }
    }
}
