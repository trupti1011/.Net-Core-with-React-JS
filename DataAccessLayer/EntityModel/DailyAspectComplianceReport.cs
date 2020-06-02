using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DailyAspectComplianceReport
    {
        public long Id { get; set; }
        public DateTime ReportDate { get; set; }
        public string AspectVersion { get; set; }
        public string Process { get; set; }
        public double? TotalCalls { get; set; }
        public double? TotalRecordings { get; set; }
        public double? MissingCount { get; set; }
        public string Recording { get; set; }
        public string Missing { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
