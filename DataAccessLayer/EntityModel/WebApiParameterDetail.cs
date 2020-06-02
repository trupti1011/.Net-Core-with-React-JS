using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WebApiParameterDetail
    {
        public long WebApiPdid { get; set; }
        public long? WebApiMid { get; set; }
        public string Parameter { get; set; }
        public int? MiscMid { get; set; }
        public byte? Status { get; set; }
        public int? ControlType { get; set; }
        public int? ClientMid { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public string ParameterValue { get; set; }
    }
}
