using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class FileStatusMaster
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
