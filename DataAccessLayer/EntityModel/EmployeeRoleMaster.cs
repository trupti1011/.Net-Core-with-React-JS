using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmployeeRoleMaster
    {
        public decimal RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? Isactive { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
    }
}
