using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WatActionStatusMaster
    {
        public byte ActionSmid { get; set; }
        public string ActionStatus { get; set; }
        public string ActionGroup { get; set; }
        public string StatusMessage { get; set; }
        public string ActionImage { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
