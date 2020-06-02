using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SubOutcomeMasterLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public int? SubOutcomeMid { get; set; }
        public int? OutcomeMid { get; set; }
        public string SubOutcome { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
        public byte? SubOutcomeType { get; set; }
        public byte? CallbackType { get; set; }
        public byte? PerformanceCriteria { get; set; }
        public string Description { get; set; }
        public string DialerCode { get; set; }
    }
}
