using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class StatusMaster
    {
        public decimal Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string ModuleName { get; set; }
        public int? IndexValue { get; set; }
        public string FieldName { get; set; }
        public bool? IsActive { get; set; }
    }
}
