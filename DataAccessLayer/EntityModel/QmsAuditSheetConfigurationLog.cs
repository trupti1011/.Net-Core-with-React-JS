using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class QmsAuditSheetConfigurationLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? AuditScid { get; set; }
        public long? AuditSmid { get; set; }
        public string HeaderLevel1SectionColSpan { get; set; }
        public string HeaderLevel1SectionColWidth { get; set; }
        public string HeaderLevel1ScoreColSpan { get; set; }
        public string HeaderLevel1ScoreColWidth { get; set; }
        public string HeaderLevel2SectionColSpan { get; set; }
        public string HeaderLevel2SectionColWidth { get; set; }
        public string HeaderLevel2ScoreColSpan { get; set; }
        public string HeaderLevel2ScoreColWidth { get; set; }
        public string ParameterColSpan { get; set; }
        public string ParameterColWidth { get; set; }
        public string OptionColSpan { get; set; }
        public string OptionColWidth { get; set; }
        public bool? NewRowForOption { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
        public string ReasonColSpan { get; set; }
        public string ReasonColWidth { get; set; }
        public string ReasonDetailColSpan { get; set; }
        public string ReasonDetailColWidth { get; set; }
        public int? ClientMid { get; set; }
    }
}
