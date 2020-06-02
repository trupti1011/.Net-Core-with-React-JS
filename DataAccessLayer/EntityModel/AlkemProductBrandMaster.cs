using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AlkemProductBrandMaster
    {
        public int ProductBrandId { get; set; }
        public string ProductBrandName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? DivisionId { get; set; }
    }
}
