﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DispositionLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedOn { get; set; }
        public string LogCreatedBy { get; set; }
        public long DispositionMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? ClientMid { get; set; }
        public long? ParentDid { get; set; }
        public string Disposition { get; set; }
        public byte? DispositionLevel { get; set; }
        public byte? DispositionType { get; set; }
        public byte? IsDependent { get; set; }
        public string DiallerCode { get; set; }
        public string PerformanceCriteria { get; set; }
        public string Description { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public int? NextActionLevel { get; set; }
        public int? NextCallDurationDifference { get; set; }
        public byte? DiallerMode { get; set; }
    }
}