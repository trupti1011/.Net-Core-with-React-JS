using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CollectionsHelpDeskProductionDetails
    {
        public decimal CollectionsHelpDeskProductionDetailsId { get; set; }
        public string Market { get; set; }
        public string TicketNumber { get; set; }
        public string TicketType { get; set; }
        public string Disposition { get; set; }
        public string Comments { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Apt { get; set; }
        public string EntryUser { get; set; }
    }
}
