using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseFaqmaster
    {
        public long Kbfmid { get; set; }
        public byte? Kbfaqtype { get; set; }
        public string Kbfaqquestion { get; set; }
        public string Kbfaqanswer { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ClientMid { get; set; }
        public string Kbmid { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
        public string Faqnumber { get; set; }
        public string FileName { get; set; }
    }
}
