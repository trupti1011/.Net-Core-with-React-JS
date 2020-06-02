using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DetectionSiteSearchUrl26092018
    {
        public int DetSsuid { get; set; }
        public int? DetSmid { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
