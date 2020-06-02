using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataFlowUploadTemplatesMaster
    {
        public int TemplateMid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public int? DataFlowMid { get; set; }
        public string TemplateFileName { get; set; }
        public byte? Freezestatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
