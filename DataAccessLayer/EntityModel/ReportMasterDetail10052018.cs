using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportMasterDetail10052018
    {
        public int Id { get; set; }
        public bool? IsClientReport { get; set; }
        public string ExcelName { get; set; }
        public string Rdlname { get; set; }
        public string RdldetailName { get; set; }
        public string RdlchartName { get; set; }
        public string ReportHeader { get; set; }
        public bool? FreezeStatus { get; set; }
        public string ReportDetailName { get; set; }
        public int? AdvanceFilter { get; set; }
        public string ReportHeaderGrid { get; set; }
        public string ReportHeaderChart { get; set; }
        public bool? AutoLoad { get; set; }
        public int? ReportServer { get; set; }
        public int? ReportFolder { get; set; }
        public bool? Tab { get; set; }
        public bool? ExportToTxt { get; set; }
    }
}
