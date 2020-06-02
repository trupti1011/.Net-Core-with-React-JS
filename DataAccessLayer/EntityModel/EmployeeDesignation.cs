using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmployeeDesignation
    {
        public int DesignationId { get; set; }
        public string Designation { get; set; }
        public string EntryBy { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
