using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ProcessorEscalationTrails
    {
        public decimal ProcessorEscalationTrailsId { get; set; }
        public decimal? ApproductionDetailsId { get; set; }
        public string EscalationComments { get; set; }
        public string Tlcomments { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
    }
}
