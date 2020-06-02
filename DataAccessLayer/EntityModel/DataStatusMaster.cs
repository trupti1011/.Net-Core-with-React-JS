using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataStatusMaster
    {
        public long StatusMid { get; set; }
        public string StatusName { get; set; }
        public byte FressStatus { get; set; }
        public string DisplayName { get; set; }
    }
}
