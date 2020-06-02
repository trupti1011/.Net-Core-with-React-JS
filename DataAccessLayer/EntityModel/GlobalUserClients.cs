using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserClients
    {
        public int GlobalUserClientId { get; set; }
        public int GlobalUserId { get; set; }
        public int ClientMid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }

        public virtual GlobalUsers GlobalUser { get; set; }
    }
}
