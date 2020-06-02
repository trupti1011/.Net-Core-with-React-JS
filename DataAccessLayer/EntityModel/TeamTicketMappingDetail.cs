using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TeamTicketMappingDetail
    {
        public long TeamTicketMappingId { get; set; }
        public long? TeamId { get; set; }
        public long? TicketDid { get; set; }
        public byte? RequestType { get; set; }
        public byte? Type { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public long? LtwoAssignToId { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public DateTime? UpdatedDateTimeUtc { get; set; }
    }
}
