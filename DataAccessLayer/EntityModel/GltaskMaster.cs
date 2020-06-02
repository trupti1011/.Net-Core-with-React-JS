using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GltaskMaster
    {
        public int GltaskMasterId { get; set; }
        public string WindowsLoginId { get; set; }
        public string Region { get; set; }
        public string Process { get; set; }
        public string Activity { get; set; }
        public string RecurrenceType { get; set; }
        public string Description { get; set; }
        public int? TimeZoneId { get; set; }
        public int? DiffInMinutes { get; set; }
        public bool? IsActive { get; set; }
        public string EntryUser { get; set; }
        public string EntryDate { get; set; }
        public string ActivityGroup { get; set; }
        public string ActivitySubGroup { get; set; }
        public bool? IsMecactivity { get; set; }
    }
}
