using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportServer10052018
    {
        public int ReportSid { get; set; }
        public string ServerName { get; set; }
        public string ReportServer { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public bool? FreezeStatus { get; set; }
    }
}
