using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class HruserRolesGlobalUsers
    {
        public int HruserRolesGlobalUsersRoleId { get; set; }
        public int? HrsourceRoleId { get; set; }
        public string EmployeeNo { get; set; }
        public int? GlobalUserId { get; set; }
        public DateTime? RoleStartDate { get; set; }
        public DateTime? RoleLeaveDate { get; set; }
        public int? HrsiteMid { get; set; }
        public int? HrdepartmentMid { get; set; }
        public int? HrpostMid { get; set; }
        public int? HrdivisionMid { get; set; }
        public string TelephonyId { get; set; }
        public int? LeaverReasonNumber { get; set; }
        public bool? Leaver { get; set; }
        public string ClientMid { get; set; }
        public int? HrsystemSourcesMid { get; set; }
        public long? RowCheckSum { get; set; }
        public string StatusFlag { get; set; }
        public int? TeamId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
