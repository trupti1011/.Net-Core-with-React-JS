using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccessLevelStaticPages
    {
        public int AccessLspid { get; set; }
        public int? AccessLmid { get; set; }
        public int? StaticPagesId { get; set; }
        public string Smdescription { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public byte? ActiveStatus { get; set; }
        public string HostName { get; set; }
    }
}
