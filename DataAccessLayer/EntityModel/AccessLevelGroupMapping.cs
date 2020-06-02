using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccessLevelGroupMapping
    {
        public int Id { get; set; }
        public int? AccessGroupTypeId { get; set; }
        public int? AccessLmid { get; set; }
        public bool? FreezeStatus { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
