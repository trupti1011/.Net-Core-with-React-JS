using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Admaster
    {
        public int Admid { get; set; }
        public string Adname { get; set; }
        public string Adpath { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
