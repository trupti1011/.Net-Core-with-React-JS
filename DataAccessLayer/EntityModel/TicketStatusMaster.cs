using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TicketStatusMaster
    {
        public long StatusMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? StatusCode { get; set; }
        public string StatusName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
