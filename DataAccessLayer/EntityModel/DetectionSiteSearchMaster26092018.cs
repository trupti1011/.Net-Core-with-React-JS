﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DetectionSiteSearchMaster26092018
    {
        public long DetSsmid { get; set; }
        public long? DetSsuid { get; set; }
        public int ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public long? MiscMid { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
