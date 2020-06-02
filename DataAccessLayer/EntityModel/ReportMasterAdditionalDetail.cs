using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportMasterAdditionalDetail
    {
        public int Id { get; set; }
        public int? ReportUidetailId { get; set; }
        public string ParameterName { get; set; }
        public string ParameterLabel { get; set; }
        public string RdlparameterName { get; set; }
        public string Spparameter { get; set; }
        public byte? ParameterControlType { get; set; }
        public string ControlPlacement { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? FreezeStatus { get; set; }
        public bool? IsVisible { get; set; }
        public string ParentControl { get; set; }
    }
}
