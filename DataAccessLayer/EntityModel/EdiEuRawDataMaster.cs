using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiEuRawDataMaster
    {
        public long RawId { get; set; }
        public int? FileUmid { get; set; }
        public string DataType { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeNoType { get; set; }
        public string GlobalUserId { get; set; }
        public string ManagerGlobalUserId { get; set; }
        public string RoleStartDate { get; set; }
        public string RoleLeaveDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Post { get; set; }
        public string Division { get; set; }
        public string Doj { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string LeaverReason { get; set; }
        public string Lanid { get; set; }
        public string SystemId { get; set; }
        public string System1Id { get; set; }
        public string System2Id { get; set; }
        public string System3Id { get; set; }
        public string System4Id { get; set; }
        public string System5Id { get; set; }
        public string System6Id { get; set; }
        public string System7Id { get; set; }
        public string Reason { get; set; }
        public byte? Status { get; set; }
    }
}
