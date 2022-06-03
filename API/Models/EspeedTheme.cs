using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EspeedTheme
    {
        public int Id { get; set; }
        public string DeleteImage { get; set; }
        public string ModImage { get; set; }
        public string AddImage { get; set; }
        public string BackgroundColor { get; set; }
        public string HeaderBgColor { get; set; }
        public string HeaderImage { get; set; }
        public string PageControlColor { get; set; }
        public string MainFrameColor { get; set; }
        public string Theme { get; set; }
        public int? UserId { get; set; }
        public string HeaderBgImage { get; set; }
        public string HeaderBgImageStyle { get; set; }
        public string FooterText { get; set; }
        public string FooterLink { get; set; }
        public string FooterFont { get; set; }
        public string FooterSize { get; set; }
    }
}
