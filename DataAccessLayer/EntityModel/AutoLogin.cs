using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AutoLogin
    {
        public int Alid { get; set; }
        public int? TemplateUserLoginMid { get; set; }
        public int? TotalLogin { get; set; }
        public int? LoginCreated { get; set; }
        public int? LoginNotCreated { get; set; }
        public byte? Status { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Host { get; set; }
        public int? AutoType { get; set; }
    }
}
