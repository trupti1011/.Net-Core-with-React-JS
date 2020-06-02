using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AlkemBrandCustomerDiscountMapping
    {
        public long DiscountMid { get; set; }
        public long? DataDid { get; set; }
        public long? DivisionId { get; set; }
        public long? BrandId { get; set; }
        public double? DiscountPer { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
