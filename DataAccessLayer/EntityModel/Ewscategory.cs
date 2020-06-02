using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Ewscategory
    {
        public int Ewscid { get; set; }
        public int Ewsmid { get; set; }
        public int? ClientId { get; set; }
        public string ParameterRef { get; set; }
        public string ParameterName { get; set; }
        public string DataType { get; set; }
        public int? Weightage { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
    }
}
