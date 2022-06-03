using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaDokumentyUwagi
    {
        public int IdZleceniaDokumentyUwagi { get; set; }
        public int? ZleceniaDokumentyId { get; set; }
        public int? DokumentyUwagiId { get; set; }
        public string OpisDod { get; set; }
    }
}
