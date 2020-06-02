using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmployeeProcess
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public bool? IsActive { get; set; }
    }
}
