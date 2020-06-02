using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MiscSearchMaster
    {
        public long SearchMid { get; set; }
        public long? ScriptMid { get; set; }
        public string MiscColLabel { get; set; }
        public int? ClientMid { get; set; }
        public string FreezeStatus { get; set; }
        public long? MiscMiD { get; set; }
        public long? IsPhoneNumber { get; set; }
    }
}
