﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ProcessLoginMappingDetailLogRamu14052018
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? ProcessLmdid { get; set; }
        public int? ProcessMid { get; set; }
        public int? LoginMid { get; set; }
        public long? GlobalUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? Status { get; set; }
        public Guid? BatchGuid { get; set; }
        public int? ClientMid { get; set; }
    }
}
