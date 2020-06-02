using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MessageBroadcastMapping
    {
        public long MappingMid { get; set; }
        public int ClientId { get; set; }
        public int MessageId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
        public byte? FreezeStatus { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
