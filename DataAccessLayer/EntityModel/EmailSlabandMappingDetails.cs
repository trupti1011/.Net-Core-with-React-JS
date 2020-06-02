using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailSlabandMappingDetails
    {
        public long EmailSlamappingId { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string EmailId { get; set; }
        public int? SlabandMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
