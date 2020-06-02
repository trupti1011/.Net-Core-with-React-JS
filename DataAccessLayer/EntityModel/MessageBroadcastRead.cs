using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MessageBroadcastRead
    {
        public long Id { get; set; }
        public long? MessageMid { get; set; }
        public long? LoginId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
        public byte? MessageTypeName { get; set; }
    }
}
