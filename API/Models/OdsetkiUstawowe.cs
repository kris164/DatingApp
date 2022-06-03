using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OdsetkiUstawowe
    {
        public int IdOdsetkiUstawowe { get; set; }
        public DateTime? DataOd { get; set; }
        public double? ProcentRocznie { get; set; }
    }
}
