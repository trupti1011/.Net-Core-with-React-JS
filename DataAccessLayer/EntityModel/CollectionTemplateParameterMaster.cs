﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CollectionTemplateParameterMaster
    {
        public long CollectionTpmid { get; set; }
        public int? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? CollectionTcmid { get; set; }
        public string DataColumnName { get; set; }
        public string DataColumnValue { get; set; }
        public string DataSource { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
