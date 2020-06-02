﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class UserProfileDetailLog
    {
        public int LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public int? UserPdid { get; set; }
        public int? LoginMid { get; set; }
        public byte? ThemeMid { get; set; }
        public string UserImageName { get; set; }
        public string UserImagePath { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
