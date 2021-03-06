﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DispositionTypeAccessLevelMappingLog
    {
        public long LogMid { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long? MappingMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? AccessLmid { get; set; }
        public int? DispositionTypeMid { get; set; }
        public bool? DefaultDispositionType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
