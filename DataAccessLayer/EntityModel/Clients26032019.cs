using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Clients26032019
    {
        public int ClientMid { get; set; }
        public string ClientName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Dbname { get; set; }
        public int? LoginUsersLimit { get; set; }
    }
}
