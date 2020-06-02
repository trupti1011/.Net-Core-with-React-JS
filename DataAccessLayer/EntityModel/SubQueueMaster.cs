using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SubQueueMaster
    {
        public decimal SubQueueId { get; set; }
        public string ModuleName { get; set; }
        public int? ProcessId { get; set; }
        public string SubQueue { get; set; }
        public bool? IsActive { get; set; }
    }
}
