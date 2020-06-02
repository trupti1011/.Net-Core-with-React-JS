using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class OcrData
    {
        public long Id { get; set; }
        public string TessData { get; set; }
        public string MsData { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Xmldata { get; set; }
    }
}
