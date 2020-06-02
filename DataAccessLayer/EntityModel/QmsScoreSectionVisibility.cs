using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class QmsScoreSectionVisibility
    {
        public int ScoreSectionVisibiltyId { get; set; }
        public string ScoreSectionName { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
