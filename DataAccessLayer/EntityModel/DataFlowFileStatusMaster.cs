using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataFlowFileStatusMaster
    {
        public int StatusDid { get; set; }
        public string StatusName { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
