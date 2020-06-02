using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ApPriorityMappingDetails
    {
        public decimal AppriorityMappingDetailsId { get; set; }
        public decimal? EmployeeId { get; set; }
        public string PriorityType { get; set; }
        public string MarketPriority1 { get; set; }
        public string MarketPriority2 { get; set; }
        public string MarketPriority3 { get; set; }
        public string QueuePriority1 { get; set; }
        public string QueuePriority2 { get; set; }
        public string QueuePriority3 { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
    }
}
