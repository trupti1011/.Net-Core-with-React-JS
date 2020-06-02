using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblInsertTransCommit
    {
        public int Id { get; set; }
        public string TransName { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
