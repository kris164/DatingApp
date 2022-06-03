using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PopupMenuConfig
    {
        public int IdPopupMenuConfig { get; set; }
        public string WinName { get; set; }
        public int UserId { get; set; }
        public int Position { get; set; }
        public string MenuItemName { get; set; }
    }
}
