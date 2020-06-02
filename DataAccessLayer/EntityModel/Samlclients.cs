using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Samlclients
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Domain { get; set; }
        public string Samlcertificate { get; set; }
        public string TargetUrl { get; set; }
        public string AssertionConsumerServiceUrl { get; set; }
        public string Issuer { get; set; }
        public DateTime? Createddatetime { get; set; }
        public bool? Freezestatus { get; set; }
    }
}
