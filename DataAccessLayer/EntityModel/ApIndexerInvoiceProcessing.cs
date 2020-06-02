using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ApIndexerInvoiceProcessing
    {
        public decimal ApindexerInvoiceProcessingId { get; set; }
        public decimal ApproductionDetailsId { get; set; }
        public string ProcessingDate { get; set; }
        public string UnitId { get; set; }
        public string Role { get; set; }
        public string ExpenseType { get; set; }
        public string InvoiceNumber { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string TotalAmount { get; set; }
        public string InvoiceDate { get; set; }
        public string Currency { get; set; }
        public string QueryType { get; set; }
        public string PoNonPo { get; set; }
        public string Ponumber { get; set; }
        public string VatTax { get; set; }
        public string SubTotal { get; set; }
        public string PoQuantityUsed { get; set; }
        public string InvoiceQuantity { get; set; }
        public string DetailedQueryActionTaken { get; set; }
        public string Status { get; set; }
        public string Requisitioner { get; set; }
        public string BatchId { get; set; }
        public string GpvoucherId { get; set; }
        public string WorkplaceId { get; set; }
        public string SecondaryReasons { get; set; }
        public string EntryDate { get; set; }
        public string InvoiceState { get; set; }
        public string InvoiceStartDate { get; set; }
        public string InvoiceEndTime { get; set; }
        public string InvoiceFirstTouchDate { get; set; }
        public string OnHoldReason { get; set; }
        public string OnHoldResolution { get; set; }
        public string InvoiceDescription { get; set; }
        public string VendorEmailId { get; set; }
        public string VendorPhoneNo { get; set; }
        public string OnHoldReasonComment { get; set; }
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
        public string InvoiceCategoryType { get; set; }
        public string Glcode { get; set; }
        public string Grnno { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string EmailSendDate { get; set; }
    }
}
