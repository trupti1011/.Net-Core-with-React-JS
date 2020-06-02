using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EvaluationDetails
    {
        public decimal EvaluationId { get; set; }
        public string EvaluationDate { get; set; }
        public string DateOfProduction { get; set; }
        public string TimeOfProduction { get; set; }
        public string RoleStartDate { get; set; }
        public string EvaluationWeek { get; set; }
        public string EvaluatorWindowsLoginId { get; set; }
        public string QueueType { get; set; }
        public string EvaluationType { get; set; }
        public string AdvisorWindowsLoginId { get; set; }
        public string TenureOfAdvisor { get; set; }
        public string EvaluationMethod { get; set; }
        public string ErrorDescription { get; set; }
        public string Rca { get; set; }
        public string ReferenceNumber { get; set; }
        public string Remarks { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
        public DateTime? StartTime { get; set; }
        public bool? IsActive { get; set; }
        public string EditedBy { get; set; }
    }
}
