using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiUploadMaster
    {
        public int UploadId { get; set; }
        public string UploadName { get; set; }
        public int? ClientMid { get; set; }
        public int? ProcessMid { get; set; }
        public int? SubProcessMid { get; set; }
        public int? Ediid { get; set; }
        public int? Category { get; set; }
        public int? ScriptMid { get; set; }
        public string TemplateFileName { get; set; }
        public string DataBaseName { get; set; }
        public string RawTableName { get; set; }
        public string DataTableName { get; set; }
        public string ClientTableName { get; set; }
        public string Description { get; set; }
        public string DateFormat { get; set; }
        public string ValidateSaveProc { get; set; }
        public bool? Scheduled { get; set; }
        public bool FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
