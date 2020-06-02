using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model
{
    class APProductionDtailsModel
    {
        public decimal ApproductionDetailsId { get; set; }
        public string EmailExchangeHeader { get; set; }
        public string ToEmailAddress { get; set; }
        public string ReceivedFrom { get; set; }
        public string ReceivedTime { get; set; }
        public string Subject { get; set; }
        public string MessageId { get; set; }
        public string Market { get; set; }
        public string SubQueue { get; set; }
        public decimal? NoOfAttachment { get; set; }
        public decimal? NoOfTransaction { get; set; }
        public string IndexerComments { get; set; }
        public string IndexerStartTime { get; set; }
        public string IndexerEndTime { get; set; }
        public string IndexedBy { get; set; }
        public bool? AssignedStatus { get; set; }
        public string AssignedUser { get; set; }
        public string AssignedDateTime { get; set; }
        public string AssignedComments { get; set; }
        public string AssignedBy { get; set; }
        public string CompletedDateTime { get; set; }
        public bool? OnHoldStatus { get; set; }
        public bool? EscalationStatus { get; set; }
        public string EscalationComments { get; set; }
        public string Disposition { get; set; }
        public string SubDisposition { get; set; }
        public string Reason { get; set; }
        public string ProcessorComments { get; set; }
        public string ProcessorStartTime { get; set; }
        public string ProcessorEndTime { get; set; }
        public decimal? NoOfTransactionsProcessor { get; set; }
        public string Status { get; set; }
        public string EmailType { get; set; }
        public string Remarks { get; set; }
        public string EmailState { get; set; }
        public string ServerReceivedTime { get; set; }
        public string FirstTouchDate { get; set; }
        public string InvoiceDescription { get; set; }
        public string OnHoldReason { get; set; }
        public string OnHoldResolution { get; set; }
        public bool? WronglyIndexedStatus { get; set; }
        public string WornglyIndexedComments { get; set; }
        public string VendorEmailId { get; set; }
        public string VendorPhoneNo { get; set; }
        public string UrgentCase { get; set; }
        public string WronglyIndexedComments { get; set; }
        public string SourceofStatement { get; set; }
        public string InputCategory { get; set; }
        public string EntityName { get; set; }
        public string InvoiceCategory { get; set; }
        public decimal? TicketId { get; set; }
    }
}
