using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SecurityQuestions
    {
        public long QuestionId { get; set; }
        public string Question { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
