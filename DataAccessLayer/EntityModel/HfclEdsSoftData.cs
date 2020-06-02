using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class HfclEdsSoftData
    {
        public int Id { get; set; }
        public string Awbno { get; set; }
        public int? OrderNo { get; set; }
        public string ProductType { get; set; }
        public string Dc { get; set; }
        public string Consignee { get; set; }
        public string ConsigneeAddress { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Mobile { get; set; }
        public string CollectableAmount { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public string Status { get; set; }
        public DateTime? ActivityScheduledDate { get; set; }
        public string Remarks { get; set; }
        public string ReasonCode { get; set; }
        public string Reason { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? NoOfAttempts { get; set; }
        public DateTime? TelecommentLatestUploadedOn { get; set; }
    }
}
