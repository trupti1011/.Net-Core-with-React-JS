using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CollectionProcessingDetails
    {
        public decimal CollectionProcessingDetailsId { get; set; }
        public decimal? EvaluationId { get; set; }
        public string CollectionCallNature { get; set; }
        public string DrillDown { get; set; }
        public string Scenario { get; set; }
        public string DocumentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string Region { get; set; }
        public string VolumeType { get; set; }
        public string TransactionDate { get; set; }
        public string Amount { get; set; }
        public string Operation { get; set; }
    }
}
