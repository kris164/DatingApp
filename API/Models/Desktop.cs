using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Desktop
    {
        public int DesktopId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }
        public int ToolId { get; set; }
        public int IconIndexId { get; set; }
        public int? UserId { get; set; }
        public int? Order { get; set; }
        public int? ProfileId { get; set; }
        public string ShortCut { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
        public int? DesktopElementFontSize { get; set; }
        public int? DesktopElementLineCount { get; set; }
    }
}
