using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ErrorTracerCrmToDialer
    {
        public int IErrorId { get; set; }
        public int? VErrorNumber { get; set; }
        public int? VErrorState { get; set; }
        public int? VErrorSeverity { get; set; }
        public int? VErrorLine { get; set; }
        public string VErrorProc { get; set; }
        public string VErrorMsg { get; set; }
        public string VUserName { get; set; }
        public string VHostName { get; set; }
        public DateTime? DErrorDate { get; set; }
    }
}
