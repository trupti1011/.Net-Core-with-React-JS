using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CurrencyMaster
    {
        public decimal CurrencyId { get; set; }
        public string Currency { get; set; }
        public string CountryName { get; set; }
        public bool? IsActive { get; set; }
    }
}
