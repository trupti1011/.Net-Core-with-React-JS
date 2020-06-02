using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class PublishKeyMapDialler
    {
        public int PublishKeyMid { get; set; }
        public string PublishKey { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public byte? IsActive { get; set; }
        public int? DiallerTableMid { get; set; }
    }
}
