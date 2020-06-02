using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ControlTypeMaster
    {
        public byte ControlTypeMid { get; set; }
        public string ControlType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public byte Csattype { get; set; }
    }
}
