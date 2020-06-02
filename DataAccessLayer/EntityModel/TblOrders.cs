using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblOrders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CutomerAddress { get; set; }
    }
}
