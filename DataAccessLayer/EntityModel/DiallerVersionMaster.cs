using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DiallerVersionMaster
    {
        public int DiallerVersionMid { get; set; }
        public string DiallerVersion { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte? Type { get; set; }
    }
}
