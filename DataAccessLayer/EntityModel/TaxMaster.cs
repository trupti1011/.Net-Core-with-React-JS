using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TaxMaster
    {
        public decimal TaxId { get; set; }
        public string MarketName { get; set; }
        public decimal? TaxPercentage { get; set; }
        public bool? IsActive { get; set; }
    }
}
