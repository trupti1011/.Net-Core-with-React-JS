using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ApProductionDetailsTrails
    {
        public decimal ApproductionDetailsTrailsId { get; set; }
        public decimal ApproductionDetailsId { get; set; }
        public string EmailExchangeHeader { get; set; }
        public string ToEmailAddress { get; set; }
        public string ReceivedFrom { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public string Subject { get; set; }
        public string MessageId { get; set; }
        public string Market { get; set; }
        public string SubQueue { get; set; }
        public decimal? NoOfAttachment { get; set; }
        public decimal? NoOfTransaction { get; set; }
        public string IndexerComments { get; set; }
        public DateTime? IndexerStartTime { get; set; }
        public DateTime? IndexerEndTime { get; set; }
        public string IndexedBy { get; set; }
        public bool? AssignedStatus { get; set; }
        public string AssignedUser { get; set; }
        public DateTime? AssignedDateTime { get; set; }
        public string AssignedComments { get; set; }
        public string AssignedBy { get; set; }
        public DateTime? CompletedDateTime { get; set; }
        public bool? OnHoldStatus { get; set; }
        public bool? EscalationStatus { get; set; }
        public string EscalationComments { get; set; }
        public string Disposition { get; set; }
        public string SubDisposition { get; set; }
        public string Reason { get; set; }
        public string ProcessorComments { get; set; }
        public DateTime? ProcessorStartTime { get; set; }
        public DateTime? ProcessorEndTime { get; set; }
        public decimal? NoOfTransactionsProcessor { get; set; }
        public string Status { get; set; }
        public string EmailType { get; set; }
        public string Remarks { get; set; }
        public string EmailState { get; set; }
        public DateTime? ServerReceivedTime { get; set; }
        public DateTime? TrailsDate { get; set; }
        public string TrailsBy { get; set; }
        public string InvoiceDescription { get; set; }
        public string OnHoldReason { get; set; }
        public string OnHoldResolution { get; set; }
        public bool? WronglyIndexedStatus { get; set; }
        public string WornglyIndexedComments { get; set; }
        public string WronglyIndexedComments { get; set; }
        public DateTime? FirstTouchDate { get; set; }
        public string VendorEmailId { get; set; }
        public string VendorPhoneNo { get; set; }
        public string UrgentCase { get; set; }
        public string SourceofStatement { get; set; }
        public string InputCategory { get; set; }
        public string EntityName { get; set; }
    }
}
