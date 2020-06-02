using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AuditdataDetail
    {
        public long AuditDdid { get; set; }
        public long? AuditSmid { get; set; }
        public string GlobalUserId { get; set; }
        public string ParentGlobalUserId { get; set; }
        public string ParentGlobalUserName { get; set; }
        public string EmployeeName { get; set; }
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string CampaignName { get; set; }
        public DateTime? CallDate { get; set; }
        public string Urn { get; set; }
        public string CallDuration { get; set; }
        public string Filename { get; set; }
        public string Filepath { get; set; }
        public long? ClientId { get; set; }
        public long? ProjectId { get; set; }
        public long? CampaignId { get; set; }
        public DateTime? AssesmentDate { get; set; }
        public string CallType { get; set; }
        public string AdvisorType { get; set; }
        public string Comments { get; set; }
        public byte? AuditStatus { get; set; }
        public long? AuditorLoginMid { get; set; }
        public DateTime? AuditDate { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? FreezeStatus { get; set; }
        public long? OutComeId { get; set; }
        public string SourceFileName { get; set; }
        public string DestinationFileName { get; set; }
        public string Encpassword { get; set; }
        public string Pilot { get; set; }
        public string CallStatus { get; set; }
        public decimal? CallScore { get; set; }
        public long? RecordingMid { get; set; }
        public string Tmcomments { get; set; }
        public string AgentComments { get; set; }
        public byte? ChangeStatus { get; set; }
        public DateTime? QbpcallStartTime { get; set; }
        public DateTime? QbpcallEndTime { get; set; }
        public string CampaignCallType { get; set; }
        public decimal? CallScr { get; set; }
        public string SupportUrn { get; set; }
        public string CallAuditType { get; set; }
        public decimal? CallScoreFatel { get; set; }
        public decimal? CallScrFatel { get; set; }
        public DateTime? Eiqdatetime { get; set; }
        public DateTime? Eiddatetime { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public string FeedbackBy { get; set; }
        public long? SdgHdmid { get; set; }
        public long? AuditScmid { get; set; }
        public decimal? ScoreOnlyFatal { get; set; }
        public decimal? PercentageOnlyFatal { get; set; }
        public string Tmaction { get; set; }
        public string Optional1 { get; set; }
        public string Optional2 { get; set; }
        public string Optional3 { get; set; }
        public int? TmQaErrorTag { get; set; }
        public string Callcategory { get; set; }
        public string Tenure { get; set; }
        public long? RandomizerDataMid { get; set; }
        public DateTime? AgentFeedbackDate { get; set; }
        public string AgentFeedbackBy { get; set; }
        public string Deletecomments { get; set; }
        public DateTime? SystemDateTime { get; set; }
        public DateTime? SystemUpdatedDateTime { get; set; }
        public DateTime? AuditStartTime { get; set; }
        public decimal? CallOpp { get; set; }
    }
}
