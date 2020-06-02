using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EwsparameterMaster
    {
        public int Edspmid { get; set; }
        public string ParameterName { get; set; }
        public string Description { get; set; }
        public bool? FreezeStatus { get; set; }
    }
}
