using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataDetailUploadBatchMapping
    {
        public long Ddubmid { get; set; }
        public long? DataDid { get; set; }
        public long? DataFlowBdid { get; set; }
        public long? TempDataDid { get; set; }
    }
}
