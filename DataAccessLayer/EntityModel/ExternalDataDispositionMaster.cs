using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ExternalDataDispositionMaster
    {
        public long DispositionMid { get; set; }
        public int? ClientMid { get; set; }
        public long? ScriptMid { get; set; }
        public string DispositionCode { get; set; }
        public string DispositionDescription { get; set; }
        public bool? Connected { get; set; }
        public bool? Contacted { get; set; }
        public string ExternalDataType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
