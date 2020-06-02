using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TicketAssignmentDetail
    {
        public long Id { get; set; }
        public long? Did { get; set; }
        public int? ScriptMid { get; set; }
        public byte? RequestType { get; set; }
        public int? AssigneeId { get; set; }
        public int? AssignerId { get; set; }
        public DateTime? AssignedDateTime { get; set; }
        public DateTime? AssignedDateTimeUtc { get; set; }
    }
}
