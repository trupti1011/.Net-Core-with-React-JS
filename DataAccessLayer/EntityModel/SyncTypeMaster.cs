using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SyncTypeMaster
    {
        public byte SyncTid { get; set; }
        public string SyncType { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
