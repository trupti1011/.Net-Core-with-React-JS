using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EwsmasterLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int Ewsmid { get; set; }
        public int SubProcessId { get; set; }
        public int? ClientId { get; set; }
        public string TemplateName { get; set; }
        public string HrmailId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
