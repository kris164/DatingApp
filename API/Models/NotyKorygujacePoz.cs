using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class NotyKorygujacePoz
    {
        public int IdNotyKorygujacePoz { get; set; }
        public int? NotyKorygujaceId { get; set; }
        public int? FakturaId { get; set; }
        public string Faktura { get; set; }
        public int? FakturaOtrzymana { get; set; }
        public string TypDok { get; set; }
    }
}
