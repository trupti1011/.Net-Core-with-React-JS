using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EwsdataDetailLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long Ewsdid { get; set; }
        public int? Ewsmid { get; set; }
        public int? ClientId { get; set; }
        public string GlobalUserId { get; set; }
        public string Para1 { get; set; }
        public string Para2 { get; set; }
        public string Para3 { get; set; }
        public string Para4 { get; set; }
        public string Para5 { get; set; }
        public string Para6 { get; set; }
        public string Para7 { get; set; }
        public string Para8 { get; set; }
        public string Para9 { get; set; }
        public string Para10 { get; set; }
        public string Para11 { get; set; }
        public string Para12 { get; set; }
        public string Para13 { get; set; }
        public string Para14 { get; set; }
        public string Para15 { get; set; }
        public string Para16 { get; set; }
        public string Para17 { get; set; }
        public string Para18 { get; set; }
        public string Para19 { get; set; }
        public string Para20 { get; set; }
        public string EmpStatus { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
