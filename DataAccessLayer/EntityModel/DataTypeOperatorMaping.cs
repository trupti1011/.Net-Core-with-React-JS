using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataTypeOperatorMaping
    {
        public int DataTypeOperatorMapingId { get; set; }
        public int ExcelDataTypeId { get; set; }
        public int OperatorId { get; set; }
    }
}
