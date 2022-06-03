using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyUwagiRodz
    {
        public int IdKierowcyUwagiRodz { get; set; }
        public string Rodzaj { get; set; }
        public int? Typ { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
