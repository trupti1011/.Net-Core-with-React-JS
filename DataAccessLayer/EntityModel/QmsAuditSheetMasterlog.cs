using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class QmsAuditSheetMasterlog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDateTime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? AuditSmid { get; set; }
        public string SheetName { get; set; }
        public int? Headerlevel { get; set; }
        public int? ScoreSectionVisibility { get; set; }
        public int? DataAvailability { get; set; }
        public int? PercentageCalcLogic { get; set; }
        public int? AuditTypeApplicable { get; set; }
        public int? AuditSccid { get; set; }
        public bool? EmailToAdvisor { get; set; }
        public string EmailValidationOn { get; set; }
        public string EmailOn { get; set; }
        public decimal? MinimumValue { get; set; }
        public decimal? MaximumValue { get; set; }
        public byte? ConfigurationType { get; set; }
        public byte? HideParameterTable { get; set; }
        public int ScoreHeaderRequired { get; set; }
        public string ScoreHeaderText { get; set; }
        public byte Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public int? ClientMid { get; set; }
    }
}
