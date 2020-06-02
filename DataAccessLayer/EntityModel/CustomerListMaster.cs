using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CustomerListMaster
    {
        public decimal CustomerListId { get; set; }
        public string Market { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public decimal? MarketId { get; set; }
    }
}
