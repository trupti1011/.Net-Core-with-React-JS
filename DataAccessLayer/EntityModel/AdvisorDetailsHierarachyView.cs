using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AdvisorDetailsHierarachyView
    {
        public string AdvisorEmployeeNumber { get; set; }
        public string AdvisorEmployeeName { get; set; }
        public string AdvisorTeamLeader { get; set; }
        public string AdvisorTeamManager { get; set; }
        public string AdvisorManager { get; set; }
        public string Process { get; set; }
        public string WindowsLoginId { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string Tenure { get; set; }
        public DateTime? ProductionDate { get; set; }
    }
}
