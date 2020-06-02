using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Hrsites
    {
        public int HrsiteMid { get; set; }
        public int? HrsourceSiteId { get; set; }
        public string HrsiteName { get; set; }
        public int? HrsystemSourcesMid { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte? FreezeStatus { get; set; }
        public Guid? BatchGuid { get; set; }
    }
}
