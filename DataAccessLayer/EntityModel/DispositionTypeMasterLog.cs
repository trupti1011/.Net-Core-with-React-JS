using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DispositionTypeMasterLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int? DispositionTypeMid { get; set; }
        public string DispositionType { get; set; }
        public byte? FreezeStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string HostName { get; set; }
    }
}
