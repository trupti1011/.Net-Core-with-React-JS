using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class UserDefaultRedirect
    {
        public int RedirectMid { get; set; }
        public int ScriptMid { get; set; }
        public int AccessLevel { get; set; }
        public string Urltitle { get; set; }
        public string Url { get; set; }
        public byte? LinkType { get; set; }
        public int? LinkOrder { get; set; }
        public string PageName { get; set; }
        public byte? PageLevel { get; set; }
        public string NextLevelPath { get; set; }
    }
}
