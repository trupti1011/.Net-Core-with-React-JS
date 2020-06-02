﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class OutcomeControlAccessLevelDetailLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? OutcomeAlid { get; set; }
        public int? SubOutcomeMid { get; set; }
        public int? AccessLmid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public int? ClientMid { get; set; }
    }
}
