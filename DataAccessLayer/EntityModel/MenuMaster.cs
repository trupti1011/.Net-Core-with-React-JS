using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MenuMaster
    {
        public int Id { get; set; }
        public int? MenuMdid { get; set; }
        public string MenuName { get; set; }
        public int? MenuOrder { get; set; }
        public bool? FreezeStatus { get; set; }
    }
}
