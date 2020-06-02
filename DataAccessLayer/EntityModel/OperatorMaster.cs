using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class OperatorMaster
    {
        public int OperatorMid { get; set; }
        public string OperatorName { get; set; }
        public string OperatorSymbol { get; set; }
        public byte? FreezeStatus { get; set; }
        public bool? IsReplacementValue { get; set; }
        public bool? IsExpressionToSearch { get; set; }
        public bool? IsTextBox { get; set; }
        public string TextBoxDataType { get; set; }
    }
}
