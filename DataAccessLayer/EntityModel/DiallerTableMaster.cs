using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DiallerTableMaster
    {
        public int DiallerTableMid { get; set; }
        public string TableName { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public string IsActive { get; set; }
    }
}
