using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TimeZoneMaster
    {
        public int Tzmid { get; set; }
        public string DisplayName { get; set; }
        public string StandardName { get; set; }
        public byte Dsapplicable { get; set; }
        public int Utcoffset { get; set; }
        public byte? FreezeStatus { get; set; }
        public byte? WebDefault { get; set; }
        public byte? AppDefault { get; set; }
        public byte? Dbdefault { get; set; }
    }
}
