using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseFeedbackDetail
    {
        public long Kbfdid { get; set; }
        public int? Kbdid { get; set; }
        public int? LoginMid { get; set; }
        public int? Rating { get; set; }
        public string Feedback { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
    }
}
