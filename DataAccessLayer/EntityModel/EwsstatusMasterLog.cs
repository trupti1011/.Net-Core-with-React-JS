using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EwsstatusMasterLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int Ewssmid { get; set; }
        public int? ClientId { get; set; }
        public string StatusName { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
