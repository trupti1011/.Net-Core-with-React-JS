using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccessDetailLog
    {
        public long LogId { get; set; }
        public long? LogCreatedBy { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogHostName { get; set; }
        public long? AccessDid { get; set; }
        public long? LoginMid { get; set; }
        public long? MenuMdid { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
    }
}
