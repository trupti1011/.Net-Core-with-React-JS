using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MessageBroadcast
    {
        public long MessageMid { get; set; }
        public byte? MessageType { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Client { get; set; }
        public string ScriptMid { get; set; }
        public string AccessType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public long? MessageCategoryId { get; set; }
    }
}
