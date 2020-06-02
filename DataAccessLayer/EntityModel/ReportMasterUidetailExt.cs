using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportMasterUidetailExt
    {
        public int Id { get; set; }
        public int? ReportMasterUiid { get; set; }
        public string ReportTypeRadio1 { get; set; }
        public string ReportTypeRadio2 { get; set; }
        public string ReportTypeRadio3 { get; set; }
        public string ReportTypeRadio4 { get; set; }
        public string Site { get; set; }
        public string Client { get; set; }
        public string Project { get; set; }
        public string Campaign { get; set; }
        public string Qa { get; set; }
        public string Cdm { get; set; }
        public string Tm { get; set; }
        public string Agent { get; set; }
        public bool? FreezeStatus { get; set; }
        public string Language { get; set; }
        public string Pg { get; set; }
        public string Pilot { get; set; }
        public string WorkGroup { get; set; }
        public string WorkDivision { get; set; }
        public string WorkItem { get; set; }
        public string Zone { get; set; }
        public string Segment { get; set; }
        public string Circle { get; set; }
    }
}
