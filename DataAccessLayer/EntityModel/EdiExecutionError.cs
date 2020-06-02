using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiExecutionError
    {
        public int ErrorId { get; set; }
        public int ExecutionId { get; set; }
        public int? FileFormatId { get; set; }
        public int? FieldId { get; set; }
        public int? RuleId { get; set; }
        public int? RowId { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorSample { get; set; }
        public string ErrorType { get; set; }
    }
}
