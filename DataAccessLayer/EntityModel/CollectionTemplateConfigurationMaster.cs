using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CollectionTemplateConfigurationMaster
    {
        public long CollectionTcmid { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public string TemplateType { get; set; }
        public string TemplateName { get; set; }
        public string Template { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
