using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ApProductionOutcomeDetails
    {
        public decimal ApproductionOutcomeDetailsId { get; set; }
        public decimal ApproductionDetailsId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string EntryUser { get; set; }
        public DateTime? EntryDateTime { get; set; }
    }
}
