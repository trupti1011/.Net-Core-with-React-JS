using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TicketDescriptionLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long? TicketDdid { get; set; }
        public long? DataDid { get; set; }
        public long TicketDid { get; set; }
        public string TicketNo { get; set; }
        public string Para111 { get; set; }
        public string Para112 { get; set; }
        public string Para113 { get; set; }
        public string Para114 { get; set; }
        public string Para115 { get; set; }
        public string Para116 { get; set; }
        public string Para117 { get; set; }
        public string Para118 { get; set; }
        public string Para119 { get; set; }
        public string Para120 { get; set; }
        public string Para121 { get; set; }
        public string Para122 { get; set; }
        public string Para123 { get; set; }
        public string Para124 { get; set; }
        public string Para125 { get; set; }
        public string Para126 { get; set; }
        public string Para127 { get; set; }
        public string Para128 { get; set; }
        public string Para129 { get; set; }
        public string Para130 { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public DateTime? UpdatedDateTimeUtc { get; set; }
        public DateTime? LogCreatedDateTimeUtc { get; set; }
    }
}
