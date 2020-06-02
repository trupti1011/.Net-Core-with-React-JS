using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class AccountThemeDetails
    {
        public long ThemeDid { get; set; }
        public int? ClientMid { get; set; }
        public string HeaderBackgroundColor { get; set; }
        public string WelcomeTextColor { get; set; }
        public string BodyHeadingText { get; set; }
        public string MenuBackground { get; set; }
        public string MenuTextColor { get; set; }
        public string RightMenubackground { get; set; }
        public string RightMenuborder { get; set; }
        public string RightMenuTextColor { get; set; }
        public string RightMenuNextPreBackground { get; set; }
        public string RightMenuNextPreTextColor { get; set; }
        public string RightMenuNextPreBackgroundHover { get; set; }
        public string RightMenuNextPreTextColorHover { get; set; }
        public string TableBackground { get; set; }
        public string PopupHeaderBackground { get; set; }
        public string PopupHeaderTextColor { get; set; }
        public string PopupHeaderCloseTextColor { get; set; }
        public string ButtonBackground { get; set; }
        public string ButtonTextColor { get; set; }
        public string ButtonBackgroundHover { get; set; }
        public string ButtonTextColorHover { get; set; }
        public string SearchButtonBackground { get; set; }
        public string SearchButtonTextColor { get; set; }
        public string SearchButtonBackgroundHover { get; set; }
        public string SearchButtonTextColorHover { get; set; }
        public string FooterBackground { get; set; }
        public string FooterTextColor { get; set; }
        public string StylesheetName { get; set; }
        public byte? FreezeStatus { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string HostName { get; set; }
    }
}
