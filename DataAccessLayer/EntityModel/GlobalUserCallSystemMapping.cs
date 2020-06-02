using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserCallSystemMapping
    {
        public long GlobalUserCallSystemId { get; set; }
        public long? GlobalUserId { get; set; }
        public int? ClientId { get; set; }
        public string TelephonyLogon { get; set; }
        public string SystemUserId01 { get; set; }
        public string SystemUserId02 { get; set; }
        public string SystemUserId03 { get; set; }
        public string SystemUserId04 { get; set; }
        public string SystemUserId05 { get; set; }
        public string SystemUserId06 { get; set; }
        public string SystemUserId07 { get; set; }
        public string SystemUserId08 { get; set; }
        public string SystemUserId09 { get; set; }
        public string SystemUserId10 { get; set; }
        public string TotalViewId { get; set; }
        public string TotalViewLogon { get; set; }
        public string Vbopslogon { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? FreezeDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string AlttelephonyId { get; set; }
        public string NetworkId { get; set; }
    }
}
