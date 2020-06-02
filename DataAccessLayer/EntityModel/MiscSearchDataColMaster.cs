using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MiscSearchDataColMaster
    {
        public long MiscSdmid { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? MiscSearchTypeMid { get; set; }
        public string MiscMasterColName { get; set; }
        public string MiscMasterColLabel { get; set; }
        public int? MiscMasterColDataType { get; set; }
        public int? MiscMasterColLength { get; set; }
        public byte? IsCli { get; set; }
        public string SqlsearchType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
