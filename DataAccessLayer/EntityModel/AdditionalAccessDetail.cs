using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AdditionalAccessDetail
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string Description { get; set; }
        public bool? Freezestatus { get; set; }
        public DateTime? Createddatetime { get; set; }
    }
}
