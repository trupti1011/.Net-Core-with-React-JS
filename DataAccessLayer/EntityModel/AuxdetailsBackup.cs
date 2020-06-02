using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AuxdetailsBackup
    {
        public decimal AuxdetailsBackupId { get; set; }
        public decimal AuxdetailsId { get; set; }
        public decimal? EmployeeId { get; set; }
        public string WindowsLoginId { get; set; }
        public string Auxcode { get; set; }
        public DateTime? AuxstartTime { get; set; }
        public DateTime? AuxendTime { get; set; }
        public string AuxendTimeUpdatedBy { get; set; }
        public decimal? SecondsTickedBySystem { get; set; }
        public decimal? AuxupdatedByEmployeeId { get; set; }
        public string AuxupdatedByWindowsLoginId { get; set; }
        public string DayStartStatus { get; set; }
        public string Pcname { get; set; }
        public string Ipaddress { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
        public string BackupUser { get; set; }
        public DateTime? BackupDate { get; set; }
    }
}
