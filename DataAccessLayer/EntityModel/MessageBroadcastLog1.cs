using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class MessageBroadcastLog1
    {
        public long LogId { get; set; }
        public DateTime? LogCreatedDatetime { get; set; }
        public string LogCreatedBy { get; set; }
        public string LogHost { get; set; }
        public long? Id { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string Host { get; set; }
        public bool? FreezeStatus { get; set; }
        public byte? Tm { get; set; }
        public byte? Cdm { get; set; }
        public byte? Cdd { get; set; }
        public byte? Md { get; set; }
        public byte? SuperAdmin { get; set; }
        public byte? Admin { get; set; }
        public byte? Qa { get; set; }
        public byte? Qbp { get; set; }
        public byte? Qc { get; set; }
        public byte? Client { get; set; }
        public byte? External { get; set; }
        public byte? Misexecutive { get; set; }
        public byte? Mismanager { get; set; }
        public byte? Trainer { get; set; }
        public byte? TrainingManager { get; set; }
        public byte? Bolevel1 { get; set; }
        public byte? Bolevel2 { get; set; }
        public byte? Bolevel3 { get; set; }
    }
}
