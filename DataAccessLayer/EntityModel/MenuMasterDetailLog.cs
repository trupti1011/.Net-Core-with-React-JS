using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MenuMasterDetailLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHostName { get; set; }
        public long? MenuMdid { get; set; }
        public long? MenuParentId { get; set; }
        public string MenuName { get; set; }
        public string PageName { get; set; }
        public int? MenuLevel { get; set; }
        public int? SrNo { get; set; }
        public string Image { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? Iscustomise { get; set; }
        public byte? AccessLmid { get; set; }
        public int? LoginMid { get; set; }
        public long? CustomiseRdid { get; set; }
        public byte? IsReport { get; set; }
        public int? ReportType { get; set; }
        public int? Type { get; set; }
        public string HeaderPart { get; set; }
        public int? ReportDetailId { get; set; }
        public int? ReportUidetailId { get; set; }
        public string RdlreportType { get; set; }
        public string ClientId { get; set; }
        public string Url { get; set; }
        public string GoBack { get; set; }
        public int? Menutype { get; set; }
        public byte? Exception { get; set; }
    }
}
