using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CollectionProductionInvoiceProcessingDetails
    {
        public decimal CollectionInvoiceProcessingDetailsId { get; set; }
        public decimal? CollectionIndexerId { get; set; }
        public string ReceiptType { get; set; }
        public string BankChequeBookId { get; set; }
        public string LocalAmount { get; set; }
        public string Usdamount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string ReasonforOnHold { get; set; }
        public string ReasonsforPartiallyposted { get; set; }
        public string Gpreference { get; set; }
        public string Actiontakenforpending { get; set; }
        public string Ticket { get; set; }
        public string AssignedUser { get; set; }
        public bool? AssignedStatus { get; set; }
        public string AssignedDate { get; set; }
        public string AssignedBy { get; set; }
        public string IndexedUser { get; set; }
        public string IndexedDate { get; set; }
        public string IndexerStartTime { get; set; }
        public string IndexerEndTime { get; set; }
        public string Remarks { get; set; }
        public string ProcessorStartTime { get; set; }
        public string ProcessorEndTime { get; set; }
        public bool? ProcessorCompletedStatus { get; set; }
        public bool? ProcessorStatus { get; set; }
        public string ReslutionComment { get; set; }
        public string InputReceivedDate { get; set; }
        public string TransactionDate { get; set; }
        public string Categorization { get; set; }
        public string BanOrcustomerNo { get; set; }
        public string CurrencyRate { get; set; }
        public string ModeofPayment { get; set; }
    }
}
