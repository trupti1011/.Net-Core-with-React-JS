using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ExternalDncmaster
    {
        public long Id { get; set; }
        public long? FileUmid { get; set; }
        public long? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
