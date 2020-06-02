using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlactivityMaster
    {
        public decimal GlactivityMasterId { get; set; }
        public string ActivityGroup { get; set; }
        public string Activity { get; set; }
        public int? IsActive { get; set; }
        public string EntryDate { get; set; }
        public string EntryUser { get; set; }
        public string ActivitySubGroup { get; set; }
        public string ModuleName { get; set; }
    }
}
