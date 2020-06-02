using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblWebServicesAuthentication
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ProcessUse { get; set; }
        public bool? Freeze { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
