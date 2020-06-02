using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MenuMasterExceptionDetailLog
    {
        public long LogId { get; set; }
        public long? LogCreatedBy { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogHostName { get; set; }
        public int Mmedid { get; set; }
        public int? ClientMid { get; set; }
        public int? AccessLmid { get; set; }
        public int? MenuMdid { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
