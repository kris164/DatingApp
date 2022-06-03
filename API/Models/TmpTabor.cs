using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpTabor
    {
        public int IdTmpTabor { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? Obcy { get; set; }
        public string NrRej { get; set; }
        public int? Aktywny { get; set; }
        public int? WlascicielId { get; set; }
        public string Wlasciciel { get; set; }
        public int? TempPlus { get; set; }
    }
}
