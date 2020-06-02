using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class HeaderColumnMappingMaster
    {
        public int HeaderCmmid { get; set; }
        public string ExcelName { get; set; }
        public string ExcelColumnName { get; set; }
        public string DbcolumnName { get; set; }
        public int? ClientMid { get; set; }
        public int? ScriptMid { get; set; }
        public byte? Type { get; set; }
        public int? Order { get; set; }
        public int? StartRow { get; set; }
        public string DataTypeFormat { get; set; }
        public string DataType { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
    }
}
