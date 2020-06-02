using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseFaqsearchDetails
    {
        public long SearchDid { get; set; }
        public string SearchText { get; set; }
        public string ClientMid { get; set; }
        public string Kbmid { get; set; }
        public string AccessLmid { get; set; }
        public int? DataRows { get; set; }
        public int? FreezeStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string HostName { get; set; }
    }
}
