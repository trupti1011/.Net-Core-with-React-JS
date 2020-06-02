using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportStatusMaster
    {
        public byte ReportStatusMid { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public string Createdby { get; set; }
        public byte? Freezestatus { get; set; }
    }
}
