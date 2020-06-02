using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailTypeMaster
    {
        public decimal EmailTypeId { get; set; }
        public string EmailType { get; set; }
        public bool IsActive { get; set; }
    }
}
