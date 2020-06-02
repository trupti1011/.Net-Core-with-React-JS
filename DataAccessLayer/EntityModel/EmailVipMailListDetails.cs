using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EmailVipMailListDetails
    {
        public int VmListId { get; set; }
        public string EmailAddress { get; set; }
        public int VipRuleId { get; set; }
        public int MatchCriteriaId { get; set; }
        public bool Status { get; set; }
    }
}
