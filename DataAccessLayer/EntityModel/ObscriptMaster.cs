using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ObscriptMaster
    {
        public int ScriptMid { get; set; }
        public string ScriptName { get; set; }
        public int? SubProcessMid { get; set; }
        public string HeaderRightImage { get; set; }
        public string HeaderLeftImage { get; set; }
        public string HeaderCenterText { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public int? ClientMid { get; set; }
        public byte? IsApplicable { get; set; }
        public byte? Verifier { get; set; }
        public byte? TeamLead { get; set; }
        public byte? Telecaller { get; set; }
        public string CallingType { get; set; }
        public int? ScriptType { get; set; }
        public byte? Skill { get; set; }
        public byte? SkillPreference { get; set; }
        public byte? Queue { get; set; }
        public byte? QueuePreference { get; set; }
        public byte? TopPreference { get; set; }
        public byte PerformanceCriteria { get; set; }
        public byte TicketApplicable { get; set; }
        public byte EmailApplicable { get; set; }
        public byte DataAllocationType { get; set; }
        public int? PrimaryScriptMid { get; set; }
        public string ReportDumpName { get; set; }
        public byte? MailVerification { get; set; }
        public byte? MailExeConfig { get; set; }
        public byte? IsActivityTracker { get; set; }
        public byte? TabApplicable { get; set; }
        public byte? SearchApplicable { get; set; }
        public byte? SaveNextApplicable { get; set; }
        public byte? IsDiallerApplicable { get; set; }
        public byte? GroupingRequired { get; set; }
        public byte? IsCallingApplicable { get; set; }
        public byte? AutoSearchApplicable { get; set; }
        public byte? Slaapplicable { get; set; }
        public int? Tzmid { get; set; }
        public byte WebApiApplicable { get; set; }
    }
}
