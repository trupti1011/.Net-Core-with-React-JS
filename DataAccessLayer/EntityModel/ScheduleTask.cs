using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScheduleTask
    {
        public int ScheduleTaskId { get; set; }
        public int GltaskMasterId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string RecurrenceType { get; set; }
        public int? DaysInterval { get; set; }
        public int? WeeksInterval { get; set; }
        public int? MonthInterval { get; set; }
        public string WeekDayName { get; set; }
        public string WeekDayNumber { get; set; }
        public string LastRunDate { get; set; }
        public string NextRunDate { get; set; }
        public bool? IsActive { get; set; }
        public string LastRefreshDate { get; set; }
        public string Market { get; set; }
        public string ReOpenReason { get; set; }
    }
}
