using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiProcessParameters
    {
        public int ParameterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
