using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AdminRoleAssignDetail
    {
        public long AdminRadid { get; set; }
        public long? LoginMidRoleAssignedBy { get; set; }
        public long? LoginMidRoleAssignedTo { get; set; }
        public DateTime? AssignedRoleStartDate { get; set; }
        public DateTime? AssignedRoleEndDate { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public byte? Status { get; set; }
    }
}
