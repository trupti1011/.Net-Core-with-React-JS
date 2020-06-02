using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class QmsAuditSheetCategoryConfigMaster
    {
        public int AuditSccid { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
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
        public bool NewRowForOption { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ReasonColSpan { get; set; }
        public string ReasonColWidth { get; set; }
        public string ReasonDetailColSpan { get; set; }
        public string ReasonDetailColWidth { get; set; }
    }
}
