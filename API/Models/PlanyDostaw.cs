using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PlanyDostaw
    {
        public int IdPlanyDostaw { get; set; }
        public int? HarmonogramyId { get; set; }
        public int? HarmonogramyPozId { get; set; }
        public DateTime? DataWyjazdu { get; set; }
        public DateTime? GodzWyjazdu { get; set; }
        public string Status { get; set; }
        public DateTime? MaxDataGodzRej { get; set; }
        public int? DzienTygNr { get; set; }
        public DateTime? DataGodzOd { get; set; }
        public DateTime? DataGodzDo { get; set; }
        public int? Wolny { get; set; }
    }
}
