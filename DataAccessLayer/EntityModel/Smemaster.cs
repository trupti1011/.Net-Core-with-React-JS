using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Smemaster
    {
        public long Smeid { get; set; }
        public long? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string Smename { get; set; }
        public string SmeemailId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
