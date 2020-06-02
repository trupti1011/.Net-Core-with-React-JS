using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TimezoneDlconfig
    {
        public long TzconfigId { get; set; }
        public int? Tzmid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Offset { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
