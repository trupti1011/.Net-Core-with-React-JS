using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AlkemUserDivisionMapping
    {
        public long AlkemUserDivisionMid { get; set; }
        public long? AlkemUserId { get; set; }
        public long? DivisionId { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Createdby { get; set; }
    }
}
