using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WMagTowaryZamienniki
    {
        public int IdWMagTowaryZamienniki { get; set; }
        public int WMagTowaryNadrzId { get; set; }
        public int WMagTowaryPodrzId { get; set; }
    }
}
