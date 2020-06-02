using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EntityMaster
    {
        public EntityMaster()
        {
            MarketMaster = new HashSet<MarketMaster>();
        }

        public decimal EntityId { get; set; }
        public string EntityName { get; set; }
        public string CodeAsPerGp { get; set; }
        public string EmailId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<MarketMaster> MarketMaster { get; set; }
    }
}
