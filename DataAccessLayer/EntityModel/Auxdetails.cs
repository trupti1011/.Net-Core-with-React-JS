using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Auxdetails
    {
        public decimal AuxdetailsId { get; set; }
        public decimal? EmployeeId { get; set; }
        public string WindowsLoginId { get; set; }
        public string Auxcode { get; set; }
        public DateTime? AuxstartTime { get; set; }
        public DateTime? AuxendTime { get; set; }
        public string AuxendTimeUpdatedBy { get; set; }
        public decimal? SecondsTickedBySystem { get; set; }
        public string DayStartStatus { get; set; }
        public string Pcname { get; set; }
        public string Ipaddress { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? BackupStatus { get; set; }
    }
}
