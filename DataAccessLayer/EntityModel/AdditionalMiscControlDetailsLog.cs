using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AdditionalMiscControlDetailsLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long? MappingMid { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? MiscMid { get; set; }
        public long? MiscDid { get; set; }
        public string EncMiscDid { get; set; }
        public long? DependentMiscMid { get; set; }
        public byte? DependentMiscTypeId { get; set; }
        public byte? IsHidden { get; set; }
        public byte? IsMandatory { get; set; }
        public string Validation { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
