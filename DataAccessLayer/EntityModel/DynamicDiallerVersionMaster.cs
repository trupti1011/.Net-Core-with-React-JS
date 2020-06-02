using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DynamicDiallerVersionMaster
    {
        public int DynamicDiallerVersionMid { get; set; }
        public int? DiallerVersionMid { get; set; }
        public int? DiallerTypeMid { get; set; }
        public string DiallerVersion { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
