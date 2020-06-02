using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DispositionControlMapping21082018
    {
        public long MappingId { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? DispositionMid { get; set; }
        public long? MiscMid { get; set; }
        public long? AccessLevel { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
