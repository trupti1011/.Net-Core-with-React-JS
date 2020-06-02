using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataFlowTypeMaster
    {
        public int DataFlowTypeMid { get; set; }
        public string DataFlowType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
    }
}
