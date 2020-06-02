using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiExecution
    {
        public int ExecutionId { get; set; }
        public int FileUmid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? RowsAffected { get; set; }
        public string FileName { get; set; }
        public int? FileId { get; set; }
        public bool IsFileRejected { get; set; }
        public long? RowsRejected { get; set; }
        public string Comments { get; set; }
        public string EmailXml { get; set; }
        public string LogXml { get; set; }
    }
}
