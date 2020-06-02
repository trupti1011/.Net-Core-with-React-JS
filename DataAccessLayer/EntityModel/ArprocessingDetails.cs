using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ArprocessingDetails
    {
        public decimal ArprocessingDetailsId { get; set; }
        public decimal? EvaluationId { get; set; }
        public string DocumentNumber { get; set; }
        public string Region { get; set; }
        public string VolumeType { get; set; }
        public string TransactionAudit { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Activities { get; set; }
        public string Categorization { get; set; }
    }
}
