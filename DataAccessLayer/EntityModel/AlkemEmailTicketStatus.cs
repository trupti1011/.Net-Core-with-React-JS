using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AlkemEmailTicketStatus
    {
        public long StatusId { get; set; }
        public long? TicketId { get; set; }
        public int? CustomerType { get; set; }
        public byte? IsCapLimitExceed { get; set; }
        public int? TicketStatus { get; set; }
        public int? EmailStatus { get; set; }
        public byte? IsStockistCalled { get; set; }
        public byte? IsDoctorCalled { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CallBackDateTime { get; set; }
        public string CallBackComments { get; set; }
    }
}
