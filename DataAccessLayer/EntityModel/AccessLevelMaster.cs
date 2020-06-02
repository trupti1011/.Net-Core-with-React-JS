using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccessLevelMaster
    {
        public int AccessLmid { get; set; }
        public string Accesslevel { get; set; }
        public string LevelDescription { get; set; }
        public int? Hierachy { get; set; }
        public int? AccessGroupTypeId { get; set; }
        public int? OrderBy { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
