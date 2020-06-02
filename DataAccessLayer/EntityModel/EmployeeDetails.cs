using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmployeeDetails
    {
        public decimal EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string WindowsLoginId { get; set; }
        public string Process { get; set; }
        public decimal? SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string Location { get; set; }
        public decimal? RoleId { get; set; }
        public string Remarks { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
        public bool? Isactive { get; set; }
        public bool? IsReport { get; set; }
        public DateTime? AttritionDate { get; set; }
        public bool? IsInternalQc { get; set; }
    }
}
