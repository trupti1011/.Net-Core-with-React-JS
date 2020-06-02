using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class ServerMaster
    {
        public int Id { get; set; }
        public string ServerIp { get; set; }
        public string AppUrl { get; set; }
        public string ServerType { get; set; }
        public byte? FreezeStatus { get; set; }
    }
}
