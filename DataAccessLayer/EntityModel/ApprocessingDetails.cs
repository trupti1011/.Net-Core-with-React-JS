using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ApprocessingDetails
    {
        public decimal ApprocessingDetailsId { get; set; }
        public decimal? EvaluationId { get; set; }
        public string TransactionAuditDuration { get; set; }
        public string VendorId { get; set; }
        public string ClassId { get; set; }
        public string PaymentId { get; set; }
        public string ClearingDate { get; set; }
        public string OnTimeDelayed { get; set; }
        public string DelayedAgeing { get; set; }
        public string Currency { get; set; }
        public string DocumentNumber { get; set; }
        public string Gross { get; set; }
        public string InvoiceNumber { get; set; }
        public string Region { get; set; }
        public string VolumeType { get; set; }
        public string Scenario { get; set; }
        public string Category { get; set; }
        public string CoCode { get; set; }
        public string TransactionDate { get; set; }
        public string VendorName { get; set; }
        public string InvoiceAmount { get; set; }
        public string Market { get; set; }
        public string SubQueue { get; set; }
        public string ProcessedInGp { get; set; }
        public string QueryRaisedToMarket { get; set; }
        public string HoldReason { get; set; }
        public string QueryRaisedBy { get; set; }
        public string QueryType { get; set; }
        public string AcknowledgeAgingDays { get; set; }
        public string TicketNumber { get; set; }
        public string DelayedAgingDays { get; set; }
    }
}
