using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class IniHist
    {
        public int IdIniHist { get; set; }
        public DateTime? DataGodzPliku { get; set; }
        public string PlikIni { get; set; }
        public string PlikBoot { get; set; }
        public string PlikBootExt { get; set; }
    }
}
