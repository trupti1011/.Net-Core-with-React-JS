using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SubOutcomeTypeMaster
    {
        public int SubOutcomeTypeMid { get; set; }
        public string SubOutcomeType { get; set; }
        public byte? FreezeStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
