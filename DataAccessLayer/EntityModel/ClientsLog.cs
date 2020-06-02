using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ClientsLog
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public int? ClientMid { get; set; }
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
