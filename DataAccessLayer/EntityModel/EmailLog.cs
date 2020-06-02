using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailLog
    {
        public int EmailLogDid { get; set; }
        public long? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public long? TicketDid { get; set; }
        public byte? TicketType { get; set; }
        public string DetailInfo { get; set; }
        public string EmailBody { get; set; }
        public string LoginMid { get; set; }
        public DateTime? LogDateTime { get; set; }
    }
}
