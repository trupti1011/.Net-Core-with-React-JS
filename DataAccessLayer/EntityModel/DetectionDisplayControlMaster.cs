using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DetectionDisplayControlMaster
    {
        public long DetDcmmid { get; set; }
        public int? DetSsuid { get; set; }
        public int ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public long? MiscMid { get; set; }
        public string Outputvalue { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
