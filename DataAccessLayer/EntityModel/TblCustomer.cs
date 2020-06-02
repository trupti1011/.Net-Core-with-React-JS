using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class TblCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerAge { get; set; }
        public string Orders { get; set; }
        public bool IsActive { get; set; }
        public string CustomerName { get; set; }
    }
}
