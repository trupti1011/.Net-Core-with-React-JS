using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EwscategoryOptions
    {
        public long Ewscoid { get; set; }
        public int Ewscid { get; set; }
        public int? ClientId { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
