using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ClientReportMappingMaster
    {
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
