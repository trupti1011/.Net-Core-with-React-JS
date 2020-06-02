using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TicketSmeemailDetails
    {
        public long MappingDid { get; set; }
        public long? TicketDid { get; set; }
        public byte? RequestType { get; set; }
        public long? Smeid { get; set; }
        public long? EmailDid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
