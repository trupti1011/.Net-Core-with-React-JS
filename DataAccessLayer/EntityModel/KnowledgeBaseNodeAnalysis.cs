using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class KnowledgeBaseNodeAnalysis
    {
        public long AnalysisNodeMid { get; set; }
        public long? Kbdid { get; set; }
        public string SeachTerm { get; set; }
        public int? LoginMid { get; set; }
        public int? TotalTime { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string Host { get; set; }
        public int? ClientMid { get; set; }
    }
}
