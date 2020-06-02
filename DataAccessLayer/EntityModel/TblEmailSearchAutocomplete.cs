using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblEmailSearchAutocomplete
    {
        public long Id { get; set; }
        public long? ScriptMid { get; set; }
        public string EmailId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}
