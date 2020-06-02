using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MiscExternalDataColMaster
    {
        public long MiscMid { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? MiscExternalTypeMid { get; set; }
        public string MiscColName { get; set; }
        public string MiscColLabel { get; set; }
        public int? MiscColDataType { get; set; }
        public int? MiscColLength { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
