using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportMasterUidetail
    {
        public int Id { get; set; }
        public string ReportType { get; set; }
        public string GroupBy { get; set; }
        public string Client { get; set; }
        public string Project { get; set; }
        public string Campaign { get; set; }
        public string Pg { get; set; }
        public string Pilot { get; set; }
        public string Cdm { get; set; }
        public string Tm { get; set; }
        public string Agent { get; set; }
        public string WorkGroup { get; set; }
        public string WorkDivision { get; set; }
        public string WorkItem { get; set; }
        public string Remarks { get; set; }
        public bool? FreezeStatus { get; set; }
        public string Qa { get; set; }
        public string EvaluationType { get; set; }
        public string Site { get; set; }
        public string Language { get; set; }
        public string CheckGroup { get; set; }
        public string ReportUiname { get; set; }
        public string CustomiseRdid { get; set; }
        public string Zone { get; set; }
        public string Segment { get; set; }
        public string Circle { get; set; }
    }
}
