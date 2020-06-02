using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KbsubCategoryMaster
    {
        public int Kbsmid { get; set; }
        public int? Kbcmid { get; set; }
        public string SubCategoryName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
        public int? Status { get; set; }
        public string Comments { get; set; }
    }
}
