using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class FileSynkingDetail
    {
        public long FileSdid { get; set; }
        public byte? WebAccess { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public byte[] FileByte { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ContentType { get; set; }
        public byte FileStatus { get; set; }
        public long? Kbfmid { get; set; }
    }
}
