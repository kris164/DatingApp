using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OkresRozliczeniowy
    {
        public int IdOkresRozliczeniowy { get; set; }
        public int IdFirma { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public DateTime? GodzinyNocneStart { get; set; }
    }
}
