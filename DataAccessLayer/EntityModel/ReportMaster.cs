using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ReportMaster
    {
        public long Rmid { get; set; }
        public long Ivgid { get; set; }
        public int? SourceId { get; set; }
        public string SubProgram { get; set; }
        public int? CallId { get; set; }
        public string Cseid { get; set; }
        public string VerifierCseid { get; set; }
        public DateTime? UploadDate { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
        public string CurrentCardType { get; set; }
        public string BillingAddress { get; set; }
        public string EligibleCardType { get; set; }
        public string CurrentCreditLimit { get; set; }
        public string RevisedCreditLimit { get; set; }
        public DateTime? CallBackDateTime { get; set; }
        public int? OutComeId { get; set; }
        public string OutComeDescription { get; set; }
        public string OutComeCode { get; set; }
        public long? ParentOutcomeId { get; set; }
        public DateTime? CallStDateTime { get; set; }
        public DateTime? CallEndDateTime { get; set; }
        public string CalledPhoneNo { get; set; }
        public string Remarks { get; set; }
        public string CallType { get; set; }
        public string VerificationType { get; set; }
        public string LoginFullName { get; set; }
        public string LoginName { get; set; }
        public string LoginType { get; set; }
        public int? ReportingTo { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public string CardType { get; set; }
        public string Multi { get; set; }
        public string AirIndiaFrequentFlierProgramNo { get; set; }
        public string LoyaltyTier { get; set; }
        public string EmailId { get; set; }
        public string Isverified { get; set; }
        public string CardFeeRenuelDate { get; set; }
        public string TravelActive { get; set; }
        public string AlternateAddress { get; set; }
        public string OfficeAddress { get; set; }
        public string EmployerName { get; set; }
        public string CustomFlag { get; set; }
        public string VerifierRemarks { get; set; }
        public int? VerifierOutcomeId { get; set; }
        public string TotalSpends { get; set; }
        public string DepartmentalGrocerySpends { get; set; }
        public string DiningSpends { get; set; }
        public string InternationalSpends { get; set; }
        public string CurrentCardRewardPoints { get; set; }
        public string EligibleCardRewardPoints { get; set; }
        public string Milestone { get; set; }
        public string TotalBenefit { get; set; }
        public string Source { get; set; }
        public string Address { get; set; }
        public string OnlineSpends { get; set; }
        public string Lob { get; set; }
        public string McTotalCreditLimit { get; set; }
        public string McRevisedCreditLimit { get; set; }
        public string McScCreditLimit { get; set; }
    }
}
