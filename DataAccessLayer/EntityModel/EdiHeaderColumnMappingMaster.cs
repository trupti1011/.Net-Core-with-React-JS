using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiHeaderColumnMappingMaster
    {
        public int HeaderCmid { get; set; }
        public int? UploadMid { get; set; }
        public string ExcelColumnName { get; set; }
        public string DbcolumnName { get; set; }
        public string DataTypeFormat { get; set; }
        public string DataType { get; set; }
        public string DbdataType { get; set; }
        public string ColumnCategory { get; set; }
        public bool? Encrypt { get; set; }
        public int? Order { get; set; }
        public bool? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public int? ClientMid { get; set; }
    }
}
