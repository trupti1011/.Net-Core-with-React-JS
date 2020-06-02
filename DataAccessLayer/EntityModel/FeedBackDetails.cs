using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class FeedBackDetails
    {
        public decimal FeedBackDetailsId { get; set; }
        public decimal? EvaluationId { get; set; }
        public bool? FeedbackSessionRequest { get; set; }
        public decimal? FeedbackSessionRequestNumber { get; set; }
        public bool? FeedbackSessionAcceptedStatus { get; set; }
        public DateTime? FeedbackSessionAcceptedDate { get; set; }
        public string FeedbackSessionAcceptedBy { get; set; }
        public string FeedbackGivenBy { get; set; }
        public DateTime? FeedbackGivenDate { get; set; }
        public bool? FeedbackAcceptedStatus { get; set; }
        public DateTime? FeedbackAcceptedDate { get; set; }
        public string FeedbackAcceptedUser { get; set; }
        public string FeedbackQatlcomment { get; set; }
        public DateTime? FeedbackQatldate { get; set; }
        public string FeedbackQatluser { get; set; }
        public string FeedBackToAdvisor { get; set; }
        public string AdvisorFeedback { get; set; }
        public bool? FeedBackDisAgree { get; set; }
        public DateTime? FeedbackDatetime { get; set; }
        public bool? BoolCheckPageOpen { get; set; }
        public bool? BoolCheckFeedbackPageOpen { get; set; }
        public bool? SupervisorAvailable { get; set; }
        public string SupervisorName { get; set; }
        public string Result { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryUser { get; set; }
        public bool? IsActive { get; set; }
    }
}
