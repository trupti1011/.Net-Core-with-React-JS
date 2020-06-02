using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportGroupMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int? Default { get; set; }
        public int? ReportId { get; set; }
        public bool? ReportType { get; set; }
        public bool? Freeze { get; set; }
        public int? SrNo { get; set; }
    }
}
