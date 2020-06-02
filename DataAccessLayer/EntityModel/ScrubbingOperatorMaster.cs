using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScrubbingOperatorMaster
    {
        public int OperatorMid { get; set; }
        public string OperatorName { get; set; }
        public string OperatorSymbol { get; set; }
        public int? DataTypeId { get; set; }
        public byte? FreezeStatus { get; set; }
        public bool? IsReplacementValue { get; set; }
        public bool? IsExpressionToSearch { get; set; }
        public string ExpressionToSearchHeading { get; set; }
        public string ReplacementValueHeading { get; set; }

        public virtual ExcelDataTypeMaster DataType { get; set; }
    }
}
