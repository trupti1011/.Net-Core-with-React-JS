using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiFileStatus
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
