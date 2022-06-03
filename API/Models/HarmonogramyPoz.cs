using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class HarmonogramyPoz
    {
        public int IdHarmonogramyPoz { get; set; }
        public int? HarmonogramyId { get; set; }
        public int? DzienTygNr { get; set; }
        public string DzienTyg { get; set; }
        public DateTime? GodzWyjazdu { get; set; }
        public int? MaxCzasRej { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? GodzDo { get; set; }
    }
}
