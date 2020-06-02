using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailTemplateMappingMaster
    {
        public long TemplateMappingMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? TemplateMid { get; set; }
        public long? MiscDid { get; set; }
        public long? ClientMid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
