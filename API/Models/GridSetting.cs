using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GridSetting
    {
        public int GridSettingsId { get; set; }
        public string WinName { get; set; }
        public string ViewName { get; set; }
        public string Data { get; set; }
        public string Header { get; set; }
        public string GlobalSettings { get; set; }
        public int? Active { get; set; }
        public string Language { get; set; }
    }
}
