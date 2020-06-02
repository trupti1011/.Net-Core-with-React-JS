﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowScrubbingLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long? DataFlowSid { get; set; }
        public long? DataFlowMid { get; set; }
        public string Displayquery { get; set; }
        public string ScrubbingQuery { get; set; }
        public int? Priority { get; set; }
        public byte? Status { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
