using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class EspeedTabsLabel
    {
        public int Id { get; set; }
        public int? IdEspeedTabs { get; set; }
        public string TextBoxLabel { get; set; }
        public int? NrPola { get; set; }
        public string TextBoxVar { get; set; }
        public string TextBoxType { get; set; }
    }
}
