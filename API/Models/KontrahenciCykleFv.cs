using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahenciCykleFv
    {
        public int IdKontrahenciCykleFv { get; set; }
        public string Nazwa { get; set; }
        public string Interwal { get; set; }
        public int? Przyrost { get; set; }
        public int? Widoczny { get; set; }
        public string Symbol { get; set; }
        public int? Poczatek { get; set; }
        public int? OstDRob { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
