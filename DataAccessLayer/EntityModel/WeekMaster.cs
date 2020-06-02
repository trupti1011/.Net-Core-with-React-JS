using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class WeekMaster
    {
        public long WeekMid { get; set; }
        public DateTime? Date { get; set; }
        public string WeekName { get; set; }
        public string WeekId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string MonthName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
