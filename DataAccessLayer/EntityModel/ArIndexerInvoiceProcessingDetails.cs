using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ArIndexerInvoiceProcessingDetails
    {
        public decimal ArinvoiceProcessingDetailsId { get; set; }
        public decimal ArindexerId { get; set; }
        public string Status { get; set; }
        public string OnHoldReason { get; set; }
        public string Ref { get; set; }
        public decimal? InvoiceValue { get; set; }
        public string IndexerComments { get; set; }
        public string InputExpectedDate { get; set; }
        public string ReceivedDate { get; set; }
        public string FileName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public string Currency { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TradeDiscount { get; set; }
        public string Tax { get; set; }
        public decimal? TotalAmount { get; set; }
        public string InvoiceNumber { get; set; }
        public string Supervisor { get; set; }
        public string AssignedUser { get; set; }
        public bool? AssignedStatus { get; set; }
        public string AssignedDate { get; set; }
        public string AssignedBy { get; set; }
        public string IndexedUser { get; set; }
        public string IndexedDate { get; set; }
        public string IndexerStartTime { get; set; }
        public string IndexerEndTime { get; set; }
        public string Remarks { get; set; }
        public string ProcessorCompletedStatus { get; set; }
        public string ProcessorStartTime { get; set; }
        public string ProcessorEndTime { get; set; }
        public string QueryTo { get; set; }
        public string ResolutionStatus { get; set; }
        public string ResolutionReason { get; set; }
        public string ProcessorComments { get; set; }
        public string BatchId { get; set; }
        public string BatchDate { get; set; }
        public decimal? TaxAmount { get; set; }
        public string InternalQcassignedUser { get; set; }
        public string InternalQcAssignedDate { get; set; }
        public string ErrorControl { get; set; }
        public string InernalQcfeedbackComment { get; set; }
        public string InernalQcstatus { get; set; }
        public string InternalQcprocessedDate { get; set; }
        public bool? InternalQccheck { get; set; }
        public string InternalQcrejectedReason { get; set; }
        public string VoidedReason { get; set; }
    }
}
