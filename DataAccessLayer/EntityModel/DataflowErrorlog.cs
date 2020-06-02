using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataflowErrorlog
    {
        public long DataFelid { get; set; }
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorNumber { get; set; }
        public string ReferenceId { get; set; }
        public string CustomiseError { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public string Createdby { get; set; }
    }
}
