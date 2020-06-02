using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScriptDiallerPortalMappingMaster
    {
        public long ScriptDpmmid { get; set; }
        public int? ScriptMid { get; set; }
        public int? HrsiteMid { get; set; }
        public int? ClientMid { get; set; }
        public string PortalName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public string Ctiproxy { get; set; }
        public int? Ctiport { get; set; }
        public string AdminServerUrl { get; set; }
        public string Crmurl { get; set; }
        public string CrmserverUrl { get; set; }
        public string OnMediaWebService { get; set; }
    }
}
