using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ClientReportMappingMasterLog
    {
        public long LogMappingMid { get; set; }
        public string LogCreatedBy { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogHostName { get; set; }
        public long MappingMid { get; set; }
        public int ClientReportMid { get; set; }
        public int LoginId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
        public byte? FreezeStatus { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
