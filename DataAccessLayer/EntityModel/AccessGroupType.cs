using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccessGroupType
    {
        public long AccessGroupTypeMid { get; set; }
        public string AccessGroupType1 { get; set; }
        public byte? FreezeStatus { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
        public byte? SrNo { get; set; }
        public string Applicable { get; set; }
    }
}
