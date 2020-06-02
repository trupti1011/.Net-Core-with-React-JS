using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AspectProcessMaster
    {
        public int ProcessMid { get; set; }
        public string ProcessName { get; set; }
        public int? ClientMid { get; set; }
        public string Dbname { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
