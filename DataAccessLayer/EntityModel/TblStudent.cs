using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int? StateId { get; set; }
        public string Pincode { get; set; }
        public int? CourseId { get; set; }

        public virtual TblCourse Course { get; set; }
        public virtual TblState State { get; set; }
    }
}
