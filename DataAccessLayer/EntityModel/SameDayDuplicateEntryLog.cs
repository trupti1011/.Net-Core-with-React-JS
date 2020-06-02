using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class SameDayDuplicateEntryLog
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public string Publisher { get; set; }
        public DateTime RecordGetDateTime { get; set; }
        public string Keywords { get; set; }
        public string Si { get; set; }
        public string PolicyNumber { get; set; }
        public string OfferDetail { get; set; }
        public string ProductType { get; set; }
        public string NetPremiumPaid { get; set; }
        public string AgentName { get; set; }
        public string AgentCode { get; set; }
        public DateTime? RiskStartDate { get; set; }
        public string OfferPage { get; set; }
        public string PaymentPage { get; set; }
        public string PaymentFail { get; set; }
        public string IsComingFrom { get; set; }
    }
}
