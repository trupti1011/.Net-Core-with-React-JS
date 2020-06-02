using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ScenarioMaster
    {
        public int ScenarioId { get; set; }
        public string ScenarioName { get; set; }
        public bool? IsActive { get; set; }
    }
}
