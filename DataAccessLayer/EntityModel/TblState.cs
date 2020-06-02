using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblState
    {
        public TblState()
        {
            TblStudent = new HashSet<TblStudent>();
        }

        public int StateId { get; set; }
        public string State { get; set; }

        public virtual ICollection<TblStudent> TblStudent { get; set; }
    }
}
