using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CollectionsHelpdeskProcessingDetails
    {
        public decimal CollectionsHelpdeskProcessingDetailsId { get; set; }
        public decimal? EvaluationId { get; set; }
        public string RefNo { get; set; }
        public string CallNature { get; set; }
        public string Scenario { get; set; }
        public string InvoiceNumber { get; set; }
        public string Region { get; set; }
        public string TransactionDate { get; set; }
    }
}
