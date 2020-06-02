using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataFlowDncexternal
    {
        public long Dnceid { get; set; }
        public long? ClientMid { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Dncdate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public byte? FreeezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
