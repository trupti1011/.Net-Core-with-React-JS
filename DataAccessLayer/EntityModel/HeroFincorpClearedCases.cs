using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class HeroFincorpClearedCases
    {
        public long CaseDid { get; set; }
        public long? DataDid { get; set; }
        public DateTime? CaseClearDate { get; set; }
        public string Bucket { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
    }
}
