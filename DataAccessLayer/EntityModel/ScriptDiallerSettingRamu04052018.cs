using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScriptDiallerSettingRamu04052018
    {
        public long ScriptDiallerMid { get; set; }
        public long? ScriptMid { get; set; }
        public long? ClientMid { get; set; }
        public string DiallerTypeMid { get; set; }
        public string DiallerVersionMid { get; set; }
        public long? DiallerServiceMid { get; set; }
        public bool? ToolBar { get; set; }
        public bool? Ready { get; set; }
        public bool? Dial { get; set; }
        public string DialNumberField { get; set; }
        public bool? Hold { get; set; }
        public bool? HangUp { get; set; }
        public bool? NotReady { get; set; }
        public string ConsultDialNumberField { get; set; }
        public bool? ConsultHangUp { get; set; }
        public bool? Conference { get; set; }
        public bool? Transfer { get; set; }
        public bool? Break { get; set; }
        public bool? LogOut { get; set; }
        public string CallbackCode { get; set; }
        public string ManualCode { get; set; }
        public string ScriptPath { get; set; }
        public string Crmmode { get; set; }
        public string LoginPageName { get; set; }
        public byte? Masking { get; set; }
        public string DiallerReq { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IvrkeyPad { get; set; }
        public bool? AdvanceToolbar { get; set; }
        public bool? ConsultHold { get; set; }
        public bool? ExternalDial { get; set; }
        public bool? ConsultTransferTo { get; set; }
        public string PreviousPage { get; set; }
        public string NextPage { get; set; }
        public int? UniqueIdindex { get; set; }
        public int? PhoneIndex { get; set; }
    }
}
