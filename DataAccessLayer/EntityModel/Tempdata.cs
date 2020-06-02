using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Tempdata
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string ProcessId { get; set; }
    }
}
