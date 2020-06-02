using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class CallNatureMaster
    {
        public int CallNatureId { get; set; }
        public string CallNatureName { get; set; }
        public bool? IsActive { get; set; }
    }
}
