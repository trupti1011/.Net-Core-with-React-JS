using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class EdiCuRawDataMaster
    {
        public long RawId { get; set; }
        public int? FileUmid { get; set; }
        public string DoctorName { get; set; }
        public string HospitalName { get; set; }
        public string ContactPersonName { get; set; }
        public string CustomerPhone1 { get; set; }
        public string CustomerPhone2 { get; set; }
        public string CustomerPhone3 { get; set; }
        public string CustomerPhone4 { get; set; }
        public string CustomerEmailId { get; set; }
        public string Mr { get; set; }
        public string Mrphone1 { get; set; }
        public string Mrphone2 { get; set; }
        public string MremailId { get; set; }
        public string Abm { get; set; }
        public string Abmphone1 { get; set; }
        public string Abmphone2 { get; set; }
        public string AbmemailId { get; set; }
        public string Rbm { get; set; }
        public string Rbmphone1 { get; set; }
        public string Rbmphone2 { get; set; }
        public string RbmemailId { get; set; }
        public string Division { get; set; }
        public string Stockist { get; set; }
        public string DepotName { get; set; }
        public string MonthlyLimit { get; set; }
        public string Azgold { get; set; }
        public string Colpep { get; set; }
        public string Hemfer { get; set; }
        public string HemferXt { get; set; }
        public string Lincef { get; set; }
        public string Linokem { get; set; }
        public string Pipzo { get; set; }
        public string Prowel { get; set; }
        public string Satrogyl { get; set; }
        public string Taxclav { get; set; }
        public string Trinerve { get; set; }
        public string Ursokem { get; set; }
        public string Xone { get; set; }
        public string XoneSb { get; set; }
        public string XoneXp { get; set; }
        public string System3Id { get; set; }
        public string System4Id { get; set; }
        public string System5Id { get; set; }
        public string System6Id { get; set; }
        public string System7Id { get; set; }
        public byte? Status { get; set; }
    }
}
