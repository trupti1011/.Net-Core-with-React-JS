using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DailyUserAuxstartEndDetails
    {
        public decimal DailyUserAuxstartEndDetailsId { get; set; }
        public decimal? EmployeeId { get; set; }
        public string WindowsLoginId { get; set; }
        public decimal? FirstAuxdetailsId { get; set; }
        public decimal? LastAuxdetailsId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsRemarked { get; set; }
        public string Remarks { get; set; }
    }
}
