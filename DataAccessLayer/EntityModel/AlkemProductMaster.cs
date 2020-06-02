using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AlkemProductMaster
    {
        public int ProductId { get; set; }
        public int? ProductBrandId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public double? Cost { get; set; }
    }
}
