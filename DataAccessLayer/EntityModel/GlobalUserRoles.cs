using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserRoles
    {
        public int GlobalUserRoleId { get; set; }
        public int GlobalUserId { get; set; }
        public int GlobalUserRoleTypeId { get; set; }
        public int? ParentGlobalUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? FreezeDate { get; set; }
        public string Team { get; set; }

        public virtual GlobalUsers GlobalUser { get; set; }
        public virtual GlobalUsers ParentGlobalUser { get; set; }
    }
}
