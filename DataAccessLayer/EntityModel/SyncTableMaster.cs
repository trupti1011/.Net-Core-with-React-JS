﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SyncTableMaster
    {
        public int SyncTmid { get; set; }
        public string SyncTableName { get; set; }
        public byte? SyncTid { get; set; }
        public string InsertFetch { get; set; }
        public string UpdateFetch { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public byte? FreezeStatus { get; set; }
        public int? RunDuration { get; set; }
    }
}
