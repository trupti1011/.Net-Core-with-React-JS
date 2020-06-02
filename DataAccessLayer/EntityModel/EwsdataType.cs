using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EwsdataType
    {
        public long Ewsdtid { get; set; }
        public string DataType { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
