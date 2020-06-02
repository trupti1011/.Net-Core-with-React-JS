using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MiscColumnMasterLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? MiscMid { get; set; }
        public long? ScriptMid { get; set; }
        public string MiscColName { get; set; }
        public string MiscColLabel { get; set; }
        public byte? MiscColType { get; set; }
        public byte? MiscColIsMandatory { get; set; }
        public string MiscColValidation { get; set; }
        public int? MiscColLength { get; set; }
        public string MiscColPosition { get; set; }
        public byte? MiscIsEditable { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public int? OrderId { get; set; }
        public int? ClientMid { get; set; }
        public string Comment { get; set; }
        public decimal? Marks { get; set; }
        public byte? PerformanceCriteria { get; set; }
        public byte? Encryption { get; set; }
        public byte? DupCheck { get; set; }
        public byte? Lead { get; set; }
        public byte? IsPhoneNumber { get; set; }
        public byte? IsCli { get; set; }
        public byte? ColumnDataType { get; set; }
        public byte? DataType { get; set; }
        public byte? IsMilestone { get; set; }
        public byte? IsCheckList { get; set; }
        public byte? MailApplicable { get; set; }
        public string MailBoxId { get; set; }
        public string MailTemplate { get; set; }
        public string ContainsInTab { get; set; }
        public byte? IsMasterRequired { get; set; }
        public string SectionHeader { get; set; }
    }
}
