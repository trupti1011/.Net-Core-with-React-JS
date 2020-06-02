using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseAnalysis
    {
        public long AnalysisMid { get; set; }
        public long? Kbmid { get; set; }
        public string SeachTerm { get; set; }
        public int? LoginMid { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string Host { get; set; }
        public int? AnalysisType { get; set; }
        public int? RecordCount { get; set; }
        public int? Kbdid { get; set; }
        public string SearchType { get; set; }
        public int? ClientMid { get; set; }
    }
}
