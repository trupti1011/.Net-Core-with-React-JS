using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ThemeMaster
    {
        public byte ThemeMid { get; set; }
        public string ThemeName { get; set; }
        public string Csskey { get; set; }
        public string ImagePath { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
