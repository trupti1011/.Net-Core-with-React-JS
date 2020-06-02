using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MarketMaster
    {
        public decimal MarketId { get; set; }
        public decimal? EntityId { get; set; }
        public string MarketName { get; set; }
        public bool? IsActive { get; set; }

        public virtual EntityMaster Entity { get; set; }
    }
}
