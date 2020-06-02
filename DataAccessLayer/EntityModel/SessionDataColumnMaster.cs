using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SessionDataColumnMaster
    {
        public int SessionDid { get; set; }
        public string DataColumn { get; set; }
        public string Description { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
