using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ApIndexerInvoiceProcessingOutcomeDetails
    {
        public decimal ApindexerInvoiceProcessingOutcomeDetailsId { get; set; }
        public decimal ApindexerInvoiceProcessingId { get; set; }
        public decimal? ApproductionDetailsId { get; set; }
        public string BatchId { get; set; }
        public string GpvoucherId { get; set; }
        public string WorkplaceId { get; set; }
        public string PoNonPo { get; set; }
        public string VatTax { get; set; }
        public string Ponumber { get; set; }
        public string PoQuantityUsed { get; set; }
        public string SubTotal { get; set; }
        public string Status { get; set; }
        public string QueryType { get; set; }
        public string OnHoldReason { get; set; }
        public string InvoiceQuantity { get; set; }
        public string OnHoldResolution { get; set; }
        public string Requisitioner { get; set; }
        public string DetailedQueryActionTaken { get; set; }
        public string InvoiceDescription { get; set; }
        public string SecondaryReasons { get; set; }
        public string Comments { get; set; }
        public string InvoiceStartDate { get; set; }
        public string InvoiceEndTime { get; set; }
        public DateTime? InvoiceFirstTouchDate { get; set; }
        public string EntryUser { get; set; }
        public DateTime? EntryDateTime { get; set; }
        public string CategoryOnHold { get; set; }
        public string VoidedReason { get; set; }
        public string VoidedTransactionDate { get; set; }
        public string VoidedReprocessedDate { get; set; }
        public string VoidedReprocessedInvNo { get; set; }
        public string VoidedReprocessedInvAmt { get; set; }
        public string VoidedReprocessedVendorName { get; set; }
        public string VoidedReprocessedVendorId { get; set; }
        public string InvoiceCategory { get; set; }
        public string Recjection { get; set; }
        public string OnHoldResolutionDate { get; set; }
        public string Followup1date { get; set; }
        public string Followup1Comment { get; set; }
        public string Followup1EmailTo { get; set; }
        public string Followup1EmailFrom { get; set; }
        public string Followup1EmailSubject { get; set; }
        public string Followup1EmailDate { get; set; }
        public string Gpnumber { get; set; }
        public string GppostedDate { get; set; }
    }
}
