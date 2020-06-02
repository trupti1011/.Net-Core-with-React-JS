using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class GlDisposition
    {
        public decimal DispositionId { get; set; }
        public string Disposition { get; set; }
        public decimal? Responsibility { get; set; }
    }
}
