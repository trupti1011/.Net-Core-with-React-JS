using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SmsTemplate
    {
        public long Id { get; set; }
        public string Smstype { get; set; }
        public string Smsmessage { get; set; }
        public bool IsActive { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
