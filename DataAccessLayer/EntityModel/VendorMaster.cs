using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class VendorMaster
    {
        public decimal VendorMasterId { get; set; }
        public string Market { get; set; }
        public string MarketId { get; set; }
        public string MarketName { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string Glcode { get; set; }
        public string Gldescription { get; set; }
        public bool? IsActive { get; set; }
    }
}
