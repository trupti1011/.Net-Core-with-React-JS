using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class HrsystemSources
    {
        public int HrsystemSourcesMid { get; set; }
        public string HrsystemSourcesName { get; set; }
        public string HrsystemSourcesDescription { get; set; }
        public string HrsystemSourceShortCode { get; set; }
        public int? ClientMid { get; set; }
        public int? PrefixNumber { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public Guid? BatchGuid { get; set; }
    }
}
