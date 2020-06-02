using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SmstextMaster
    {
        public int SmstextMid { get; set; }
        public int? DispositionMid { get; set; }
        public string Smstext { get; set; }
        public byte? Status { get; set; }
        public string Bucket { get; set; }
        public string Smstype { get; set; }
        public string Language { get; set; }
    }
}
