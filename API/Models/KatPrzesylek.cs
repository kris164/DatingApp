using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KatPrzesylek
    {
        public int IdKatPrzesylek { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? DoPlanowania { get; set; }
        public string OpisDod { get; set; }
        public string OpisDod2 { get; set; }
        public string OpisDod3 { get; set; }
        public int? IsCod { get; set; }
        public int? IsBlackSquare { get; set; }
        public string UpsServiceType { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
