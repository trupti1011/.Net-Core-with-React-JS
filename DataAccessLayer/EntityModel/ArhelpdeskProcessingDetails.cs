using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ArhelpdeskProcessingDetails
    {
        public decimal ArhelpdeskProcessingDetailsId { get; set; }
        public decimal? EvaluationId { get; set; }
        public string ReferenceNumber { get; set; }
        public string CallNature { get; set; }
        public string Scenario { get; set; }
        public string InvoiceNumber { get; set; }
        public string Region { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
