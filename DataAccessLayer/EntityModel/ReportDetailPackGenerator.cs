using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportDetailPackGenerator
    {
        public long Id { get; set; }
        public string ReportServer { get; set; }
        public string Reportpath { get; set; }
        public byte FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
