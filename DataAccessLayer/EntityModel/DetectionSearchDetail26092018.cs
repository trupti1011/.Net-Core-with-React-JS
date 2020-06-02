using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DetectionSearchDetail26092018
    {
        public long DetSdid { get; set; }
        public long? DetSsuid { get; set; }
        public int? TimeTaken { get; set; }
        public int? Resultcount { get; set; }
        public string SearchData { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
