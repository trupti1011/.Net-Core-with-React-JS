using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WebApiMaster
    {
        public long WebApiMid { get; set; }
        public int? ScriptMid { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
        public string Token { get; set; }
        public byte? Status { get; set; }
        public string TabName { get; set; }
        public int? ClientMid { get; set; }
        public int? ParentId { get; set; }
        public int? IsSelect { get; set; }
        public string TokenName { get; set; }
        public string TokenValue { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public byte ResponseContentType { get; set; }
    }
}
