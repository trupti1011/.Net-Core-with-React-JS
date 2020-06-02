using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
