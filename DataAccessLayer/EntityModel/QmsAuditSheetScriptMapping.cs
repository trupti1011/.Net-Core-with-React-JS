using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class QmsAuditSheetScriptMapping
    {
        public long AuditScmid { get; set; }
        public long? AuditSmid { get; set; }
        public int? Sheetlevel { get; set; }
        public long? ScriptMid { get; set; }
        public string DisplayName { get; set; }
        public int? LanguageId { get; set; }
        public string LinkName { get; set; }
        public string FileName { get; set; }
        public byte? Parameterlevel { get; set; }
        public byte? Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public bool? ProductSale { get; set; }
        public string TableName { get; set; }
        public bool? AllTm { get; set; }
        public bool? Tmaccess { get; set; }
        public int? SiteId { get; set; }
        public bool? SendEvaluationInQuery { get; set; }
        public bool SendCriticalErrorEmail { get; set; }
        public string HeaderName { get; set; }
        public bool? AgentFeedbackFlow { get; set; }
        public int? TimeDifference { get; set; }
        public int AuditMailToTmstatus { get; set; }
        public bool FeedbackMailToAdvisor { get; set; }
        public bool DuplicacyCheckOnUrn { get; set; }
        public long? DuplicacyCheckWithMiscMid1 { get; set; }
        public long? DuplicacyCheckWithMiscMid2 { get; set; }
        public Guid? BatchGuid { get; set; }
        public byte RecordingRequired { get; set; }
        public byte AuditEditAccess { get; set; }
        public string EditAccessLmids { get; set; }
        public byte TmfeedbackRequired { get; set; }
        public decimal TmfeedbackScoreFrom { get; set; }
        public decimal TmfeedbackScoreTo { get; set; }
        public byte FeedbackScoreValidation { get; set; }
        public string TmfeedbackOn { get; set; }
        public string FeedbackScorePercentage { get; set; }
        public byte? AuditAttachmentRequired { get; set; }
        public string AuditAttachmentActualName { get; set; }
        public string AuditAttachmentName { get; set; }
        public byte? RandomizerAuditSkip { get; set; }
        public bool? FeedbackDisputedbyAgent { get; set; }
        public byte TransactionScoreApplicable { get; set; }
        public byte TransactionStatusApplicable { get; set; }
    }
}
