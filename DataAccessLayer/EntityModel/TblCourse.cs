using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblCourse
    {
        public TblCourse()
        {
            TblStudent = new HashSet<TblStudent>();
        }

        public int CourseId { get; set; }
        public string Courses { get; set; }

        public virtual ICollection<TblStudent> TblStudent { get; set; }
    }
}
