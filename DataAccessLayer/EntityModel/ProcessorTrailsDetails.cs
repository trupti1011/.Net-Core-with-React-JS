using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ProcessorTrailsDetails
    {
        public decimal ProcessorTrailsDetailsId { get; set; }
        public decimal? ApproductionDetailsId { get; set; }
        public DateTime? StartTime { get; set; }
        public string TrailsType { get; set; }
        public decimal? AptinSeconds { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
    }
}
