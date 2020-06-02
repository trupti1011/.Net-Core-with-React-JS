using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AutoLoginDetail
    {
        public long Id { get; set; }
        public int? Alid { get; set; }
        public string GlobaluserId { get; set; }
        public int? LoginMid { get; set; }
        public string DefaultPassword { get; set; }
        public byte? Status { get; set; }
        public string Reason { get; set; }
        public string LoginName { get; set; }
        public string HremployeeName { get; set; }
        public string SaltKey { get; set; }
    }
}
