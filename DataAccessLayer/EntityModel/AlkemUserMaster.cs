using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AlkemUserMaster
    {
        public long AlkemUserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public byte? Freezestatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
