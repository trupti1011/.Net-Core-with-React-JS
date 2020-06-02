using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ManualSmssend
    {
        public int Smsid { get; set; }
        public int? DataDid { get; set; }
        public string DataName { get; set; }
        public string Smstype { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
