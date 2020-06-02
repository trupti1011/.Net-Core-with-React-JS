using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class LanguageMaster
    {
        public long Lmid { get; set; }
        public string LanguageName { get; set; }
        public string LangKey { get; set; }
        public int? CreatedBy { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
