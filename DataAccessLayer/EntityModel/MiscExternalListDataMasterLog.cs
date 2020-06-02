using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MiscExternalListDataMasterLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public long MiscDid { get; set; }
        public long? MiscMid { get; set; }
        public string MiscData { get; set; }
        public bool IsDependent { get; set; }
        public long? ParentMiscMid { get; set; }
        public long? ParentMiscDid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public int? ClientMid { get; set; }
        public byte Answer { get; set; }
    }
}
