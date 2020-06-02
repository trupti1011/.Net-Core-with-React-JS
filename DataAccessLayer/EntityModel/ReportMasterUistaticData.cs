using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportMasterUistaticData
    {
        public int Id { get; set; }
        public int? ReportUidetailId { get; set; }
        public string Client { get; set; }
        public string Project { get; set; }
        public string Campaign { get; set; }
        public string Cdm { get; set; }
        public string Tm { get; set; }
        public string Agent { get; set; }
        public string Qa { get; set; }
        public string Remarks { get; set; }
        public bool? FreezeStatus { get; set; }
    }
}
