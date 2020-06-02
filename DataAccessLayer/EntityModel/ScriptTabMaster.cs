using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScriptTabMaster
    {
        public long TabMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public string TabHeader { get; set; }
        public byte? SectionCount { get; set; }
        public string Section1Header { get; set; }
        public string Section2Header { get; set; }
        public string Section3Header { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
