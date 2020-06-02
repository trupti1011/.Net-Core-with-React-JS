using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class BankReconMaster
    {
        public decimal BankReconId { get; set; }
        public string MarketId { get; set; }
        public string Market { get; set; }
        public string Ownership { get; set; }
        public string CheckBookId { get; set; }
        public string Glcode { get; set; }
        public string Gldescription { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public bool? IsActive { get; set; }
    }
}
