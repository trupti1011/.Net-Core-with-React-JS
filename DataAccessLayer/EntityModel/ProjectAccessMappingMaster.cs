using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ProjectAccessMappingMaster
    {
        public int ProjectAccessMid { get; set; }
        public int? AccessLmid { get; set; }
        public byte? ProjectAccess { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public long? CreatedBy { get; set; }
    }
}
