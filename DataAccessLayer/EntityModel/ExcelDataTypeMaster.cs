using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ExcelDataTypeMaster
    {
        public ExcelDataTypeMaster()
        {
            ScrubbingOperatorMaster = new HashSet<ScrubbingOperatorMaster>();
        }

        public int ExcelDataTypeMid { get; set; }
        public string ExcelDataTypeMaster1 { get; set; }
        public byte? FreezeStatus { get; set; }

        public virtual ICollection<ScrubbingOperatorMaster> ScrubbingOperatorMaster { get; set; }
    }
}
