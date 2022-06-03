using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahenciKryteriumFv
    {
        public int IdKontrahenciKryteriumFv { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int? Widoczny { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
