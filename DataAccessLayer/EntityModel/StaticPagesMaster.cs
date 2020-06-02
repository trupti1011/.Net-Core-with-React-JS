using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class StaticPagesMaster
    {
        public long StaticPagesId { get; set; }
        public string MenuName { get; set; }
        public string PageName { get; set; }
        public int? MenuLevel { get; set; }
        public int? SrNo { get; set; }
        public string Image { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Host { get; set; }
    }
}
