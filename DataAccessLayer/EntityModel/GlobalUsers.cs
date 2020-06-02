using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlobalUsers
    {
        public GlobalUsers()
        {
            GlobalUserClients = new HashSet<GlobalUserClients>();
            GlobalUserProcesss = new HashSet<GlobalUserProcesss>();
            GlobalUserRolesGlobalUser = new HashSet<GlobalUserRoles>();
            GlobalUserRolesParentGlobalUser = new HashSet<GlobalUserRoles>();
            GlobalUserSubProcess = new HashSet<GlobalUserSubProcess>();
        }

        public int GlobalUserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public byte? FreezeStatus { get; set; }
        public Guid? BatchGuid { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<GlobalUserClients> GlobalUserClients { get; set; }
        public virtual ICollection<GlobalUserProcesss> GlobalUserProcesss { get; set; }
        public virtual ICollection<GlobalUserRoles> GlobalUserRolesGlobalUser { get; set; }
        public virtual ICollection<GlobalUserRoles> GlobalUserRolesParentGlobalUser { get; set; }
        public virtual ICollection<GlobalUserSubProcess> GlobalUserSubProcess { get; set; }
    }
}
