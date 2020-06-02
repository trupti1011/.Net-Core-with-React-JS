using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUserRoleTypes
    {
        public int GlobalUserRoleTypeId { get; set; }
        public string RoleName { get; set; }
        public int? ParentGlobalUserRoleTypeId { get; set; }
    }
}
