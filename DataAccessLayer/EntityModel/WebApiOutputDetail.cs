using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WebApiOutputDetail
    {
        public long WebApiOdid { get; set; }
        public long? WebApiMid { get; set; }
        public string OutputName { get; set; }
        public long? MiscMid { get; set; }
        public byte IsDisplay { get; set; }
        public int? ControlType { get; set; }
        public byte? Status { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public string Xmlnodes { get; set; }
    }
}
