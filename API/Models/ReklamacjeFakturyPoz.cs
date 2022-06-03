using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ReklamacjeFakturyPoz
    {
        public int IdReklamacjeFakturyPoz { get; set; }
        public int? ReklamacjeId { get; set; }
        public int? FakturyId { get; set; }
        public int? FakturyPozycjeId { get; set; }
    }
}
