using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class BankReconDetails
    {
        public decimal BankReconId { get; set; }
        public string MarketId { get; set; }
        public string Market { get; set; }
        public string CheckBookId { get; set; }
        public string Glcode { get; set; }
        public string Currency { get; set; }
        public string SourceofStatement { get; set; }
        public string FrequencyofStatement { get; set; }
        public string DateofReceiptofStatement { get; set; }
        public string ReconciledDate { get; set; }
        public string AccountType { get; set; }
        public string Status { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string EntryUser { get; set; }
        public bool? IsActive { get; set; }
    }
}
