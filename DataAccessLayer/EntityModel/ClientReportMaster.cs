using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ClientReportMaster
    {
        public int ClientReportMid { get; set; }
        public long ClientId { get; set; }
        public long? ParentClientReportMid { get; set; }
        public int? ReportLevel { get; set; }
        public string ClientReportName { get; set; }
        public string ClientReportPage { get; set; }
        public int? ReportOrder { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public byte? FreezeStatus { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public byte? Iscustomise { get; set; }
        public int? LoginMid { get; set; }
        public long? CustomiseRdid { get; set; }
        public int? ReportType { get; set; }
        public int? Type { get; set; }
        public string HeaderPart { get; set; }
        public int? ReportDetailId { get; set; }
        public int? ReportUidetailId { get; set; }
        public string RdlreportType { get; set; }
        public string Url { get; set; }
        public string GoBack { get; set; }
        public Guid? BatchGuid { get; set; }
        public byte? MenuType { get; set; }
    }
}
