using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class DataUploadTypeMaster
    {
        public int TypeMid { get; set; }
        public string DataUploadType { get; set; }
        public int? ScriptMid { get; set; }
        public int? ClientMid { get; set; }
        public byte? FreeseStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string HostName { get; set; }
    }
}
