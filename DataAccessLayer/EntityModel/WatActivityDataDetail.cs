using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WatActivityDataDetail
    {
        public long ActivityDid { get; set; }
        public long DataDid { get; set; }
        public long? CallHistoryMid { get; set; }
        public long? StatusDid { get; set; }
        public int? LoginMid { get; set; }
        public string GlobalUserId { get; set; }
        public byte? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ActionStartDateTime { get; set; }
        public DateTime? ActionEndDateTime { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public DateTime? ActionStartDateTimeUtc { get; set; }
        public DateTime? ActionEndDateTimeUtc { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public DateTime? UpdatedDateTimeUtc { get; set; }
    }
}
