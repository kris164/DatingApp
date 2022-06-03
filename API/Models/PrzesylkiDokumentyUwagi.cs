using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiDokumentyUwagi
    {
        public int IdPrzesylkiDokumentyUwagi { get; set; }
        public int? PrzesylkiDokumentyId { get; set; }
        public int? DokumentyUwagiId { get; set; }
        public string OpisDod { get; set; }
    }
}
