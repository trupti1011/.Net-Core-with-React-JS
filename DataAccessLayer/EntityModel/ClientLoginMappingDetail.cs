﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ClientLoginMappingDetail
    {
        public long ClientLmdid { get; set; }
        public int? ClientMid { get; set; }
        public int? LoginMid { get; set; }
        public long? GlobalUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? Status { get; set; }
        public Guid? BatchGuid { get; set; }
    }
}
