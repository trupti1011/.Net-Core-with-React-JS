using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TwitterTemplate
    {
        public long TemplateId { get; set; }
        public long? ScriptMid { get; set; }
        public string TemplateName { get; set; }
        public string TemplateBody { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
