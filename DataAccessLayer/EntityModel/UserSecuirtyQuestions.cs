using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class UserSecuirtyQuestions
    {
        public long Id { get; set; }
        public int? QuestionId { get; set; }
        public string Answer { get; set; }
        public long? LoginId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
