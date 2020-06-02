using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TableChangeLogMaster
    {
        public long ChangeLogId { get; set; }
        public string ChangeType { get; set; }
        public string ChangeDatabaseName { get; set; }
        public string ChangeTableName { get; set; }
        public string ChangeColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public string ColumnDefaultValue { get; set; }
        public bool? ColumnIsIdentity { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
